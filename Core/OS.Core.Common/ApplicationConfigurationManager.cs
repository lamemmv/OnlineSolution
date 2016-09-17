using System.Collections.Specialized;
using System.Configuration;

namespace OS.Core.Common
{
    public class ApplicationConfigurationManager : IApplicationConfigurationManager
    {
        private NameValueCollection m_AppSettings;

        public ApplicationConfigurationManager()
        {
            m_AppSettings = ConfigurationManager.AppSettings; //TODO: use later
        }

        public string GetConnectionString(string key)
        {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }
    }
}
