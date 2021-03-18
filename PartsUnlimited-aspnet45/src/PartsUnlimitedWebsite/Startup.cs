using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Owin;
using Owin;
using PartsUnlimited;
using System.Web.Configuration;

[assembly: OwinStartup(typeof(Startup))]

//comment
namespace PartsUnlimited
{
	// bellevue comment!!
	// second commit
    //new comment added
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            TelemetryConfiguration.Active.InstrumentationKey = WebConfigurationManager.AppSettings["Keys:ApplicationInsights:InstrumentationKey"];

        }
    }
}
