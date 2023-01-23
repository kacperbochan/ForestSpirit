using AutoMapper;

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using ForestSpirit.Framework;
using ForestSpirit.Framework.Customers;
using ForestSpirit.Framework.Customers.Providers;
using ForestSpirit.Framework.Customers.Records;
using ForestSpirit.Framework.Equipments;
using ForestSpirit.Framework.Equipments.Providers;
using ForestSpirit.Framework.Equipments.Records;
using ForestSpirit.Framework.Opinions;
using ForestSpirit.Framework.Opinions.Providers;
using ForestSpirit.Framework.Opinions.Records;
using ForestSpirit.Framework.Orders;
using ForestSpirit.Framework.Orders.Providers;
using ForestSpirit.Framework.Orders.Records;
using ForestSpirit.Framework.Outposts.Records;
using ForestSpirit.Framework.Products;
using ForestSpirit.Framework.Products.Providers;
using ForestSpirit.Framework.Products.Records;
using ForestSpirit.Framework.Requests;
using ForestSpirit.Framework.Requests.Providers;
using ForestSpirit.Framework.Resources;
using ForestSpirit.Framework.Resources.Providers;
using ForestSpirit.Framework.Resources.Records;
using ForestSpirit.Framework.Workers;
using ForestSpirit.Framework.Workers.Providers;
using ForestSpirit.ServiceModel.Customers;
using ForestSpirit.ServiceModel.Equipments;
using ForestSpirit.ServiceModel.Opinions;
using ForestSpirit.ServiceModel.Orders;
using ForestSpirit.ServiceModel.Outposts;
using ForestSpirit.ServiceModel.Products;
using ForestSpirit.ServiceModel.Resources;
using ForestSpirit.ServiceModel.Workers;
using ForestSpirit.Settings;

using Microsoft.Extensions.Options;

using NHibernate;

using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.IO;

using System.Text.Json.Serialization;

using AppSettings = ForestSpirit.Settings.AppSettings;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

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

        // połączenie bazy danych
        this.InstallDb(services, settings);

        // Mapping
        this.InstallMapping(services);

        // File system
        this.InstallFileSystem(services, settings);

        // CORS
        services.AddCors(
            options =>
            {
                // this defines a CORS policy called "default"
                options.AddPolicy(
                    "default",
                    policy =>
                    {
                        policy.WithOrigins("*");
                    });
            });


        services.AddMvc();
        services.AddControllers().AddJsonOptions(opt =>
        {
            opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        });
        services.AddSwaggerDocument(configure =>
        {
            configure.Title = "API aplikacji bazodanowej ForestSpirit";
        });

        // Serwisy
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<IEquipmentService, EquipmentService>();
        services.AddScoped<IOpinionService, OpinionService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IRequestService, RequestService>();
        services.AddScoped<IResourceService, ResourceService>();
        services.AddScoped<IWorkerService, WorkerService>();

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
        var sessionFactory = Fluently.Configure()
          .Database(
            MsSqlConfiguration.MsSql2012.ConnectionString(settings.Db.ConnectionString))
          .Mappings(m => m.FluentMappings.AddFromAssemblyOf<OrderMap>())
          .BuildSessionFactory();

        services.AddSingleton(sessionFactory);
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
    }

    /// <summary>
    /// Utworzenie konfiguracji mapper'a.
    /// </summary>
    /// <param name="cfg">Konfiguracja mapper'a.</param>
    private void Build(IMapperConfigurationExpression cfg)
    {
        cfg.AddProfile<GeneralMappingProfile>();
    }
}
