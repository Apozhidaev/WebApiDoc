using System.Configuration;

namespace WebApiDoc.Tests
{
    public static class AppSettings
    {
        private static readonly GlobalSection Global;

        static AppSettings()
        {
            Global = (GlobalSection)ConfigurationManager.GetSection("global");
        }

        public static string Description => Global.Description;

        public static string DisplayName => Global.DisplayName;

        public static string ServiceName => Global.ServiceName;
    }
}