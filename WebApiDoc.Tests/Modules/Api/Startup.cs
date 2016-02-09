using System.Web.Http;
using Newtonsoft.Json.Serialization;
using Owin;

namespace WebApiDoc.Tests.Modules.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.XmlFormatter.UseXmlSerializer = true;
            appBuilder.UseWebApi(config);
        }

    }
}
