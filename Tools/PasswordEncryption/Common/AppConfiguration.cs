namespace PasswordEncryption.Common
{
    public class AppConfiguration: IAppConfiguration
    {
        private readonly IApplicationConfigurationManager m_ConfigurationManager;
        private const string DefaultConnectionStringKey = "DefaultConnectionString";
        private const string PasswordFormatKey = "PasswordFormat";
        private const string PlaintextPasswordKey = "PlaintextPassword";
        private const string EncryptionKeyKey = "EncryptionKey";
        private const string EncryptionSaltKey = "EncryptionSalt";
        private const string EncryptionIVKey = "EncryptionIV";

        public string ConnectionString { get; private set; }

        public int PasswordFormat { get; private set; }

        public bool PlaintextPassword { get; private set; }

        public string EncryptionKey { get; private set; }

        public string EncryptionSalt { get; private set; }

        public string EncryptionIV { get; private set; }

        public AppConfiguration(IApplicationConfigurationManager configurationManager)
        {
            m_ConfigurationManager = configurationManager;

            Initialize();
        }

        private void Initialize()
        {
            ConnectionString = m_ConfigurationManager.GetConnectionString(DefaultConnectionStringKey);
            PasswordFormat = m_ConfigurationManager.GetInteger(PasswordFormatKey, 1);
            PlaintextPassword = m_ConfigurationManager.GetBoolean(PlaintextPasswordKey, false);
            EncryptionKey = m_ConfigurationManager.GetString(EncryptionKeyKey);
            EncryptionSalt = m_ConfigurationManager.GetString(EncryptionSaltKey);
            EncryptionIV = m_ConfigurationManager.GetString(EncryptionIVKey);
        }
    }
}
