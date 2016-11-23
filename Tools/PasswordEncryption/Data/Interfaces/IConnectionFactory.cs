using System.Data;

namespace PasswordEncryption.Data
{
    public interface IConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
