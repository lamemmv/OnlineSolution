using Dapper;
using PasswordEncryption.Entities;
using System.Collections.Generic;

namespace PasswordEncryption.Data
{
    public class Queries : ConnectionBase, IQueries
    {
        public Queries(IConnectionFactory factory)
            : base(factory)
        {
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            return Execute(connection =>
                    connection.Query<UserDTO>(@"SELECT  [iEmployeeId],
                                                        [strPassword],
                                                        [strLoginName],
                                                        [salt]
                                                FROM [dbo].[tblEmployee]"));
        }
    }
}
