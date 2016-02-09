using System;
using Microsoft.Owin.Hosting;

namespace WebApiDoc.Tests.Modules.Api
{
    public class ApiModule : IModule
    {
        private IDisposable _webApp;

        public void Start()
        {
            var startOptions = new StartOptions();
            foreach (var url in ModuleSettings.BaseAddress)
            {
                startOptions.Urls.Add(url);
            }
            _webApp = WebApp.Start<Startup>(startOptions);
        }

        public void Stop()
        {
            _webApp?.Dispose();
            _webApp = null;
        }
    }
}