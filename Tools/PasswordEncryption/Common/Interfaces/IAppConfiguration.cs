namespace PasswordEncryption.Common
{
    public interface IAppConfiguration
    {
        string ConnectionString { get; }

        int PasswordFormat { get; }

        bool PlaintextPassword { get; }

        string EncryptionKey { get; }

        string EncryptionSalt { get; }

        string EncryptionIV { get; }
    }
}
