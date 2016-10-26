namespace PasswordEncryption.Utils
{
    public interface ICryptography
    {
        string EncryptPassword(string unencryptedPassword, string salt = "");
    }
}
