using PasswordEncryption.Common;
using PasswordEncryption.Entities;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PasswordEncryption.Utils
{
    public class Cryptography : ICryptography
    {
        private readonly IAppConfiguration _configuration;

        public Cryptography(IAppConfiguration configuration) {
            _configuration = configuration;
        }
        public string EncryptPassword(string unencryptedPassword, string salt = "")
        {
            string password;

            switch (_configuration.PasswordFormat)
            {
                case (int)PasswordFormat.Clear:
                    password = unencryptedPassword;
                    break;
                case (int)PasswordFormat.Encrypted:
                    password = EncryptData(string.Format("{0}{1}", unencryptedPassword, salt));
                    break;
                case (int)PasswordFormat.Hashed:
                    password = CreateSHAHash(string.Format("{0}{1}", unencryptedPassword, salt));
                    break;
                default:
                    password = unencryptedPassword;
                    break;
            }

            return password;
        }

        /// <summary>
        /// Encrypt a input string using builtin dashboard password/salt/IV
        /// </summary>
        /// <param name="data">String to encrypt</param>
        /// <returns>Returns a base64 encoded string with the encrypted data</returns>
        private string EncryptData(string data)
        {
            byte[] b = Encoding.UTF8.GetBytes(data);
            string password = _configuration.EncryptionKey;
            string salt = _configuration.EncryptionSalt;
            return EncryptData(b, password, salt);
        }

        private string EncryptData(byte[] data, string passwordPhrase, string salt)
        {
            byte[] passwordBytes = UTF8Encoding.UTF8.GetBytes(passwordPhrase);
            byte[] saltBytes = UTF8Encoding.UTF8.GetBytes(salt);
            byte[] IVBytes = UTF8Encoding.UTF8.GetBytes(_configuration.EncryptionIV);

            PasswordDeriveBytes password = new PasswordDeriveBytes(passwordBytes, saltBytes, "SHA1", 1);
            byte[] keyBytes = password.GetBytes(32);	// 256 bits key

            RijndaelManaged aes = new RijndaelManaged();
            aes.Mode = CipherMode.CBC;


            ICryptoTransform crypto = aes.CreateEncryptor(keyBytes, IVBytes);

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, crypto, CryptoStreamMode.Write);
            cryptoStream.Write(data, 0, data.Length);
            cryptoStream.FlushFinalBlock();

            byte[] encryptedData = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();


            return Convert.ToBase64String(encryptedData);
        }

        private string CreateSHAHash(string unencryptedString)
        {
            UTF8Encoding UTF8Encoder = new UTF8Encoding();
            byte[] aryBytes = UTF8Encoder.GetBytes(unencryptedString);
            SHA512Managed sha = new SHA512Managed();
            byte[] bHashedData = sha.ComputeHash(aryBytes);
            return BitConverter.ToString(bHashedData).Replace("-", "");
        }
    }
}
