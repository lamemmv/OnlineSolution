using Dapper;
using PasswordEncryption.Entities;
using System;
using System.Collections.Generic;

namespace PasswordEncryption.Data
{
    public class Commands : ConnectionBase, ICommands
    {
        public Commands(IConnectionFactory factory)
            : base(factory)
        {
        }

        public bool UpdatePassword(UserDTO request)
        {
            try
            {
                Execute(connection =>
                {
                    connection.Execute(
                        string.Format(@"UPDATE [dbo].[tblEmployee] 
                                        SET [strPassword] = '{0}'
                                        WHERE [iEmployeeId] = {1}", request.strPassword, request.iEmployeeId));
                });

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdatePasswords(IEnumerable<UserDTO> request)
        {
            throw new NotImplementedException();
        }
    }
}
