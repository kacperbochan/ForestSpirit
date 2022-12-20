using System.Data;
using ForestSpirit.Core.ApiServices;

using ServiceStack;
using ServiceStack.Host;
using ServiceStack.Text;
using ServiceStack.Validation;
using ServiceStack.Web;

namespace ForestSpirit;

public class AppHost : AppHostBase
{

    /// <summary>
    /// Konfiguracja aplikacji.
    /// </summary>
    private readonly IConfiguration configuration;

    /// <summary>
    /// Initializes a new instance of the <see cref="AppHost"/> class.
    /// </summary>
    /// <param name="applicationName">Nazwa aplikacji.</param>
    /// <param name="configuration">Konfiguracja hosta.</param>
    public AppHost(string applicationName, IConfiguration configuration)
        : base(applicationName, typeof(ProductApiService).Assembly)
    {
        this.ApplicationName = applicationName;
        this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    /// <summary>
    /// Nazwa aplikacji.
    /// </summary>
    public string ApplicationName { get; }

    /// <inheritdoc />
    public override void Configure(Funq.Container container)
    {
        // container.CheckAdapterFirst = true;

        // JSON
        JsConfig.DateHandler = DateHandler.ISO8601;

        // Add CORS
        this.Plugins.Add(new CorsFeature(allowCredentials: true, allowedHeaders: "Content-Type, Authorization, App-Lang"));

        // Add Validation Feature
        // this.Plugins.Add(new ValidationFeature());
        container.RegisterValidators(AppDomain.CurrentDomain.GetAssemblies().Where(predicate: x => x.FullName.Contains("ForestSpirit")).ToArray());

        // Generators
        var nativeTypes = this.GetPlugin<NativeTypesFeature>();
        nativeTypes.MetadataTypesConfig.ExportAsTypes = false;

        // FIXME: obejscie problemu rozwiazywania OperationName przez domyslne handlery (GenericHandler)
        this.RawHttpHandlers.Add(
            request =>
            {
                if (request.RawUrl.StartsWith("/api", StringComparison.InvariantCultureIgnoreCase))
                {
                    return new RestHandler();
                }

                return null;
            });
    }

    /// <summary>
    /// Automatically prefix all service routes to desired path structure (in this case /api/{rest of route}).
    /// </summary>
    /// <param name="requestType">Typ żądania.</param>
    /// <returns>Atrybuty routingu.</returns>
    public override RouteAttribute[] GetRouteAttributes(Type requestType)
    {
        var routeAttributes = base.GetRouteAttributes(requestType);
        foreach (var routeAttribute in routeAttributes)
        {
            string path = routeAttribute.Path;
            if (!path.StartsWithIgnoreCase("/types") && !path.StartsWithIgnoreCase("/api"))
            {
                routeAttribute.Path = "/api" + routeAttribute.Path;
            }
        }

        return routeAttributes;
    }

    /// <inheritdoc />
    public override IDbConnection GetDbConnection(IRequest req = null)
    {
        return this.Container.Resolve<IDbConnection>();
    }
}
