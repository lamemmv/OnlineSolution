using System;
using System.Data;

namespace PasswordEncryption.Data
{
    public abstract class ConnectionBase
    {
        private readonly IConnectionFactory _connectionFactory;

        protected ConnectionBase(IConnectionFactory factory)
        {
            _connectionFactory = factory;
        }

        protected T Execute<T>(Func<IDbConnection, T> action)
        {
            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                return action(connection);
            }
        }

        protected void Execute(Action<IDbConnection> action)
        {
            using (IDbConnection connection = _connectionFactory.CreateConnection())
            {
                action(connection);
            }
        }
    }
}
