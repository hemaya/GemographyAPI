using Gemography.APIs.Setups.Factory;
using Gemography.Crosscut.Models;
using Gemography.Integration.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gemography.APIs.Setups.Services
{
    public class SettingServiceSetup : IServiceSetup
    {
        public void InstallService(IServiceCollection services, IConfiguration configuration)
        {
            var swaggerOptions = new SwaggerOptions();
            configuration.Bind(nameof(swaggerOptions), swaggerOptions);
            services.AddSingleton(swaggerOptions);

            var remoteSettings = new RemoteSettings();
            configuration.Bind(nameof(remoteSettings), remoteSettings);
            services.AddSingleton(remoteSettings);
        }
    }
}
