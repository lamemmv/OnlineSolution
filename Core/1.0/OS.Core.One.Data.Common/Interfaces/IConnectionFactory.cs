using System.Data;

namespace OS.Core.One.Data.Common
{
    public interface IConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
