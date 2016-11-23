using PasswordEncryption.Entities;
using System.Collections.Generic;

namespace PasswordEncryption.Data
{
    public interface IDataService
    {
        IEnumerable<UserDTO> GetUsers();

        void EncyptUserPasswords(IEnumerable<UserDTO> users);

        void DecryptUserPasswords(IEnumerable<UserDTO> users);
    }
}
