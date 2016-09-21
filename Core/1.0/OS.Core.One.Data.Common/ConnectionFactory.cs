using System.Data;
using System.Data.SqlClient;
using OS.Core.One.Common;

namespace OS.Core.One.Data.Common
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string m_ConnectionString;

        public ConnectionFactory(IOSConfiguration configuration)
        {
            m_ConnectionString = configuration.ConnectionString;
        }

        public IDbConnection CreateConnection()
        {
            var result = new SqlConnection(m_ConnectionString);
            result.Open();

            return result;
        }
    }
}
