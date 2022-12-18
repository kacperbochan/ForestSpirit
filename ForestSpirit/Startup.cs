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
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using ForestSpirit.Framework.Products.Records;

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
        // var logFactory = new ServiceStack.Logging.NLogger.NLogFactory();
        // ServiceStack.Logging.LogManager.LogFactory = logFactory;

        // Configuration
        var settings = this.configuration.Get<AppSettings>();
        services.AddSingleton<Microsoft.Extensions.Options.IOptions<AppSettings>>(provider => new OptionsWrapper<AppSettings>(settings));
        services.AddSingleton<Microsoft.Extensions.Options.IOptions<ResourcesSettings>>(provider => new OptionsWrapper<ResourcesSettings>(settings.Resources));


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
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }

        app.UseRouting();
        app.UseCors("default");
        app.UseStaticFiles();

        // app.UseServiceStack(new AppHost(env.ApplicationName, this.configuration));

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }

    /// <summary>
    /// Instalacja komponentów bazy danych.
    /// </summary>
    /// <param name="services">Rejestr usług aplikacji.</param>
    /// <param name="settings">Ustawienia aplikacji.</param>
    private void InstallDb(IServiceCollection services, AppSettings settings)
    {
        /*var connectionManager = new DbConnectionManager();

        var factory = this.CreateDbFactory(settings.Db, true);
        connectionManager.Register("default", factory);

        services.AddSingleton<IDbConnectionManager>(connectionManager);
        services.AddSingleton<IDbConnectionFactory>(factory);
        services.AddSingleton(factory);
        services.AddScoped(x => factory.OpenDbConnection());
        services.AddSingleton<Compiler, SqlServerCompiler>();*/

        var sessionFactory = Fluently.Configure()
          .Database(
            MsSqlConfiguration.MsSql2012.ConnectionString(settings.Db.ConnectionString))
          .Mappings(m => m.FluentMappings.AddFromAssemblyOf<OrderMap>())
          .BuildSessionFactory();

        services.AddSingleton(sessionFactory);
        /*using (var session = sessionFactory.OpenSession())
        {
            using (var transaction = session.BeginTransaction())
            {
                var barginBasin = new ProductRecord { Name = "Bargin Basin", Price = 69, Procentage = 21, CreatedBy = "kupa", ChangedBy = "kupa", CreatedDate = DateTime.Now, ChangedDate = DateTime.Now };

                // save both stores, this saves everything else via cascading
                session.Save(barginBasin, 70);

                transaction.Commit();
            }
        }*/
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
