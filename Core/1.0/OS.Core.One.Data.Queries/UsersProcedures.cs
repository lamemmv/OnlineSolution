using Dapper;
using OS.Core.One.Common.Intermediate;
using OS.Core.One.Data.Common;
using OS.Core.One.Data.Entities;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using OS.Core.One.Data.Queries.Extensions;

namespace OS.Core.One.Data.Queries
{
    public class UsersProcedures : ConnectionBase, IUsersProcedures
    {
        public UsersProcedures(IConnectionFactory factory)
            : base(factory)
        {
        }

        public int Create(int userId, UserDTO request)
        {
            return Execute(connection =>
            {
                using (var results = connection.QueryMultiple("[Core].[CreateUser]",
                    new
                    {
                        FirstName = request.FirstName,
                        LastName = request.LastName,
                        UserName = request.UserName,
                        Password = request.Password,
                        Email = request.Email,
                        UserId = userId
                    },
                    commandType: CommandType.StoredProcedure)
                )
                {
                    return results.Read<int>().SingleOrDefault();
                }
            });
        }

        public UserDTO GetById(int id)
        {
            return Execute(
                connection => connection
                    .Query<UserDTO>("[Core].[GetUserById]",
                        new
                        {
                            Id = id
                        },
                        commandType: CommandType.StoredProcedure)
                    .SingleOrDefault());
        }

        public IEnumerable<UserDTO> Get(SearchUsersRequest request)
        {
            return this.Execute(
                connection => connection.Query<UserDTO>(
                    "[Core].[GetUsers]",
                    new
                    {
                        Keyword = request.Keyword
                    },
                    commandType: CommandType.StoredProcedure));
        }

        public void Update(UserDTO request)
        {
            this.Execute(connection =>
            {
                connection.Execute(
                    "[Core].[UpdateUser]",
                    new
                    {
                        Id = request.Id,
                        FirstName = request.FirstName,
                        LastName = request.LastName,
                        Email = request.Email,
                        UserName = request.UserName,
                        Password = request.Password
                    },
                    commandType: CommandType.StoredProcedure);
            });
        }

        public void Delete(IEnumerable<int> ids)
        {
            //DataTable idsTable = ids.ConvertToIdsDataTable();
            //this.Execute(connection =>
            //{
            //    connection.Execute(
            //        "[Core].[DeleteUsers]",
            //        new
            //        {
            //            Items = idsTable
            //        },
            //        commandType: CommandType.StoredProcedure);
            //});
        }
    }
}
