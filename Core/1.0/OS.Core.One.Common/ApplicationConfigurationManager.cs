using Microsoft.Extensions.Options;
using OS.Core.One.Common.Intermediate;

namespace OS.Core.One.Common
{
    public class ApplicationConfigurationManager : IApplicationConfigurationManager
    {
        private readonly AppData _appData;

        public ApplicationConfigurationManager(IOptions<AppData> appData)
        {
            _appData = appData.Value;
        }

        public string GetConnectionString(string key)
        {
            return _appData.ConnectionString;
        }
    }
}
