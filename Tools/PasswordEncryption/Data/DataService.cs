using System;
using System.Collections.Generic;
using PasswordEncryption.Entities;
using System.Linq;
using PasswordEncryption.Utils;

namespace PasswordEncryption.Data
{
    public class DataService : IDataService
    {
        private readonly IQueries _queries;
        private readonly ICommands _command;
        private readonly ICryptography _cryptography;

        public DataService(IQueries queries, ICommands command, ICryptography cryptography)
        {
            _queries = queries;
            _command = command;
            _cryptography = cryptography;
        }

        public void DecryptUserPasswords(IEnumerable<UserDTO> users)
        {
            throw new NotImplementedException();
        }

        public void EncyptUserPasswords(IEnumerable<UserDTO> users)
        {
            var atle = users.Where(x=>x.strLoginName.Equals("atle")).SingleOrDefault();
            atle.strPassword = _cryptography.EncryptPassword(atle.strPassword, atle.Salt);
            _command.UpdatePassword(atle);
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            return _queries.GetUsers();
        }
    }
}
