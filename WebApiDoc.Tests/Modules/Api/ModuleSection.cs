using System.Configuration;

namespace WebApiDoc.Tests.Modules.Api
{
    public class ModuleSection : ConfigurationSection
    {
        [ConfigurationProperty("baseAddress", IsRequired = true)]
        public string BaseAddress => (string)this["baseAddress"];
    }
}