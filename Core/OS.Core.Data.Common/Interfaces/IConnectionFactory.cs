using System.Data;

namespace OS.Core.Data.Common
{
    public interface IConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
