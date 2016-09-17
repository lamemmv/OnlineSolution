using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.Core.Common
{
    public class OSConfiguration : IOSConfiguration
    {
        private const string DefaultConnectionStringKey = "DefaultConnectionString";
        private readonly IApplicationConfigurationManager m_ConfigurationManager;

        public OSConfiguration(IApplicationConfigurationManager configurationManager)
        {
            m_ConfigurationManager = configurationManager;

            Initialize();
        }

        private void Initialize()
        {
            ConnectionString = m_ConfigurationManager.GetConnectionString(DefaultConnectionStringKey);
        }

        public string ConnectionString { get; private set; }
    }
}
