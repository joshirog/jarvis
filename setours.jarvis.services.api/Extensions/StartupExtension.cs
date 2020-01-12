using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using setours.jarvis.services.api.Extensions.Contract;

namespace setours.jarvis.services.api.Extensions
{
    public static class StartupExtension
    {
        public static void StartupExtensionAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var extensions = typeof(setours.jarvis.services.api.Startup)
                .Assembly
                .ExportedTypes
                .Where(x => typeof(IStartupExtension).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(Activator.CreateInstance)
                .Cast<IStartupExtension>()
                .ToList();

            extensions.ForEach(extension => extension.ExtensionServices(services, configuration));
        }
    }
}
