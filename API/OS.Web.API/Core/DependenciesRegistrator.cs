using Microsoft.Extensions.DependencyInjection;
using OS.Core.One.Business;
using OS.Core.One.Business.Security;
using OS.Core.One.Common;
using OS.Core.One.Data.Common;
using OS.Core.One.Data.Queries;

namespace OS.Web.API.Core
{
    public static class DependenciesRegistrator
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IApplicationConfigurationManager, ApplicationConfigurationManager>();
            services.AddScoped<IOSConfiguration, OSConfiguration>();

            RegisterServices(services);
            RegisterDataLayers(services);
        }

        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUsersService, SecureUsersService>();
            services.AddScoped<IInternalUsersService, InternalUsersService>();
        }

        public static void RegisterDataLayers(IServiceCollection services)
        {
            services.AddScoped<IConnectionFactory, ConnectionFactory>();
            services.AddScoped<IUsersProcedures, UsersProcedures>();
        }
    }
}
