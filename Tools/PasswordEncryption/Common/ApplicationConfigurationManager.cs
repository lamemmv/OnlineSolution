using System;
using System.Collections.Specialized;
using System.Configuration;

namespace PasswordEncryption.Common
{
    public class ApplicationConfigurationManager : IApplicationConfigurationManager
    {
        private NameValueCollection m_AppSettings;

        public ApplicationConfigurationManager()
        {
            m_AppSettings = ConfigurationManager.AppSettings;
        }

        public string GetConnectionString(string key)
        {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }

        public bool GetBoolean(string key, bool defaultValue = false)
        {
            string value = m_AppSettings[key];

            if (value != null)
            {
                bool result;
                if (bool.TryParse(value, out result))
                {
                    return result;
                }
            }

            return defaultValue;
        }

        public T GetEnum<T>(string key, T defaultValue) where T : struct
        {
            string value = m_AppSettings[key];

            if (value != null)
            {
                T result;
                if (Enum.TryParse(value, out result))
                {
                    return result;
                }
            }

            return defaultValue;
        }

        public int GetInteger(string key, int defaultValue = 0)
        {
            string value = m_AppSettings[key];

            if (value != null)
            {
                int result;
                if (int.TryParse(value, out result))
                {
                    return result;
                }
            }

            return defaultValue;
        }

        public string GetString(string key)
        {
            return m_AppSettings[key];
        }
    }
}
