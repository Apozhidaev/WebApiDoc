using System.Configuration;
using System.Linq;

namespace WebApiDoc.Tests.Modules.Api
{
    public static class ModuleSettings
    {
        static ModuleSettings()
        {
            var settings = (ModuleSection)ConfigurationManager.GetSection("api");
            BaseAddress = settings.BaseAddress.Split(',', ';').Select(url => url.Last() != '/' ? $"{url}/" : url).ToArray();
        }

        public static string[] BaseAddress { get; }
    }
}