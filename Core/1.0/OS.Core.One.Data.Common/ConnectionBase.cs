﻿using System;
using System.Data;

namespace OS.Core.One.Data.Common
{
    public abstract class ConnectionBase
    {
        public ConnectionBase()
        {
        }

        private readonly IConnectionFactory m_ConnectionFactory;

        protected ConnectionBase(IConnectionFactory factory)
        {
            m_ConnectionFactory = factory;
        }

        protected T Execute<T>(Func<IDbConnection, T> action)
        {
            using (IDbConnection connection = m_ConnectionFactory.CreateConnection())
            {
                return action(connection);
            }
        }

        protected void Execute(Action<IDbConnection> action)
        {
            using (IDbConnection connection = m_ConnectionFactory.CreateConnection())
            {
                action(connection);
            }
        }
    }
}
