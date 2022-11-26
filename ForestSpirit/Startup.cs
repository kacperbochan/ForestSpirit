using AutoMapper;
using Microsoft.Extensions.Options;
using ServiceStack.Auth;
using ServiceStack.Data;
using ServiceStack.IO;
using ServiceStack.OrmLite.SqlServer.Converters;
using ServiceStack.OrmLite;
using System.Text.Json.Serialization;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using ForestSpirit.Mappings;
using ForestSpirit.Settings;
using AppSettings = ForestSpirit.Settings.AppSettings;
using SqlKata.Compilers;
using ForestSpirit.Framework.Connection;
using ServiceStack;
using ForestSpirit.Framework.Products;
using ForestSpirit.Framework.Products.Providers;

namespace ForestSpirit;

public class Startup
{
    /// <summary>
    /// Konfiguracja aplikacji.
    /// </summary>
    private readonly IConfiguration configuration;

    /// <summary>
    /// Initializes a new instance of the <see cref="Startup"/> class.
    /// </summary>
    /// <param name="env">Host aplikacji.</param>
    /// <param name="configuration">Konfiguracja aplikacji.</param>
    [Obsolete]
    public Startup(IHostingEnvironment env, IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    /// <summary>
    /// This method gets called by the runtime. Use this method to add services to the container.
    /// </summary>
    /// <param name="services">Kontener IoC.</param>
    public void ConfigureServices(IServiceCollection services)
    {
        // logging
        var logFactory = new ServiceStack.Logging.NLogger.NLogFactory();
        ServiceStack.Logging.LogManager.LogFactory = logFactory;

        // Configuration
        var settings = this.configuration.Get<AppSettings>();
        services.AddSingleton<Microsoft.Extensions.Options.IOptions<AppSettings>>(provider => new OptionsWrapper<AppSettings>(settings));
        services.AddSingleton<Microsoft.Extensions.Options.IOptions<ResourcesSettings>>(provider => new OptionsWrapper<ResourcesSettings>(settings.Resources));

        services.AddMvc(options => options.EnableEndpointRouting = false);

        this.InstallDb(services, settings);

        // CORS
        services.AddCors(
            options =>
            {
                // this defines a CORS policy called "default"
                options.AddPolicy(
                    "default",
                    policy =>
                    {
                        policy.WithOrigins(new string[]
                        {
                                "http://localhost:4200","http://localhost:44415","http://localhost:44315", "http://localhost:5000", "http://localhost:80",
                                "http://localhost",
                        })
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials();
                    });
            });

        // Mapping
        this.InstallMapping(services);

        services.AddMvc();
        services.AddControllers().AddJsonOptions(opt =>
        {
            opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        });
        services.AddSwaggerDocument(configure =>
        {
            configure.Title = "API aplikacji bazodanowej ForestSpirit";
        });

        services.AddScoped<IProductService, ProductService>();

        // File system
        this.InstallFileSystem(services, settings);

        // Walidacja
        //services.AddScoped<IValidator<ServiceModel.MeterRequest>, MeterRequestValidator>();
    }

    /// <summary>
    /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    /// </summary>
    /// <param name="app">Kreator aplikacji.</param>
    /// <param name="env">Zmienne środowiskowe.</param>
    [Obsolete]
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseCors("default");
        app.UseStaticFiles();

        app.UseServiceStack(new AppHost(env.ApplicationName, this.configuration));

        app.UseMvcWithDefaultRoute();
    }

    /// <summary>
    /// Instalacja komponentów bazy danych.
    /// </summary>
    /// <param name="services">Rejestr usług aplikacji.</param>
    /// <param name="settings">Ustawienia aplikacji.</param>
    private void InstallDb(IServiceCollection services, AppSettings settings)
    {
        var connectionManager = new DbConnectionManager();

        var factory = this.CreateDbFactory(settings.Db, true);
        connectionManager.Register("default", factory);

        services.AddSingleton<IDbConnectionManager>(connectionManager);
        services.AddSingleton<IDbConnectionFactory>(factory);
        services.AddSingleton(factory);
        services.AddScoped(x => factory.OpenDbConnection());
        services.AddSingleton<Compiler, SqlServerCompiler>();
    }

    /// <summary>
    /// Utworzenie fabryki połączenia do bazy danych.
    /// </summary>
    /// <param name="config">Konfiguracja bazy danych.</param>
    /// <param name="isDefault">Czy jest do domyślne połączenie do bazy danych.</param>
    /// <returns>Fabryka połączeń do repozytorium.</returns>
    private OrmLiteConnectionFactory CreateDbFactory(DBSettings config, bool isDefault)
    {
        string providerType = "ServiceStack.OrmLite.";

        switch (config.Dialect)
        {
            case "SqlServer":
                providerType += "SqlServer.SqlServerOrmLiteDialectProvider, ServiceStack.OrmLite.SqlServer";
                break;
            case "SqlServer2012":
                providerType += "SqlServer.SqlServer2012OrmLiteDialectProvider, ServiceStack.OrmLite.SqlServer";
                break;
            case "SqlServer2014":
                providerType += "SqlServer.SqlServer2014OrmLiteDialectProvider, ServiceStack.OrmLite.SqlServer";
                break;
            case "SqlServer2016":
                providerType += "SqlServer.SqlServer2016OrmLiteDialectProvider, ServiceStack.OrmLite.SqlServer";
                break;

            default:
                // throw new ConfigurationErrorsException($"Unknown dialect provider '{config.Dialect}'");
                break;
        }

        var type = Type.GetType(providerType);
        if (type == null)
        {
            // throw new ConfigurationErrorsException($"Unknown dialect provider type '{providerType}'.");
        }

        var provider = (IOrmLiteDialectProvider?)Activator.CreateInstance(type);

        if (provider == null)
        {
            throw new ArgumentNullException($"Provider was null.");
        }

        provider.RegisterConverter<DateTime>(new SqlServerDateTime2Converter());
        return new OrmLiteConnectionFactory(config.ConnectionString, provider, isDefault);
    }

    /// <summary>
    /// Instalacja komponentów systemu plików.
    /// </summary>
    /// <param name="services">Rejestr usług aplikacji.</param>
    /// <param name="settings">Ustawienia aplikacji.</param>
    private void InstallFileSystem(IServiceCollection services, AppSettings settings)
    {
        string rootPath = AppContext.BaseDirectory;

        var fs = new FileSystemVirtualFiles(rootPath);
        fs.EnsureDirectory("dictionary");

        services.AddSingleton<IVirtualFiles>(fs);
    }

    // <summary>
    // Dodanie usługi mapowania.
    // </summary>
    // <param name="services">Rejestr usług aplikacji.</param>
    private void InstallMapping(IServiceCollection services)
    {
        var mapperConfig = new MapperConfiguration(this.Build);
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        // services.AddSingleton<TagValueResolver>();
    }

    /// <summary>
    /// Utworzenie konfiguracji mapper'a.
    /// </summary>
    /// <param name="cfg">Konfiguracja mapper'a.</param>
    private void Build(IMapperConfigurationExpression cfg)
    {
        cfg.AddProfile<ProductMappingProfile>();
    }
}
