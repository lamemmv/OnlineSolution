using PasswordEncryption.Common;
using System.Data;
using System.Data.SqlClient;

namespace PasswordEncryption.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string _connectionString;

        public ConnectionFactory(IAppConfiguration configuration)
        {
            _connectionString = configuration.ConnectionString;
        }

        public IDbConnection CreateConnection()
        {
            var result = new SqlConnection(_connectionString);
            result.Open();

            return result;
        }
    }
}
