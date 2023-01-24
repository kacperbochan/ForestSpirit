using ForestSpirit.Framework;
using Microsoft.AspNetCore;
using NLog.Web;
using ServiceStack.Text;
using System.Globalization;
using System.Reflection.Metadata;

namespace ForestSpirit;

public class Program
{
    /// <summary>
    /// Klasa główna.
    /// </summary>
    /// <param name="args">Argumenty wywołania.</param>
    public static void Main(string[] args)
    {
        // licence
        //ServiceStack.Licensing.RegisterLicense(LicenceKeys.ServiceStack);

        var culture = CultureInfo.GetCultureInfo("pl-PL");
        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;

        // config
        JsConfig.DateHandler = DateHandler.ISO8601;

        // container
        string volumePath = AppContext.BaseDirectory;

        // logger
        //var logFactory = NLogBuilder.ConfigureNLog(Path.Combine(volumePath, "config", "log.config"));
       // var logger = logFactory.GetLogger("ForestSpirit");
       // ServiceStack.Logging.LogManager.LogFactory = new ServiceStack.Logging.NLogger.NLogFactory();

        try
        {
            // bootstrap
            var host = WebHost.CreateDefaultBuilder<Startup>(args)
                .ConfigureAppConfiguration(
                    (builderContext, config) =>
                    {
                        config.SetBasePath(volumePath)
                            .AddJsonFile(Path.Combine("config", "settings.json"));
                            //.AddEnvironmentVariables();
                    })
                //.UseNLog()
               // .UseUrls("https://localhost:5000")
                .Build();

            // run
            host.Run();
        }
        catch (Exception ex)
        {
            //logger.Fatal(ex, "Unhandled application exception.");
            throw;
        }
        finally
        {
            // flush logger
            //NLog.LogManager.Shutdown();
        }
    }
}
