using PasswordEncryption.Entities;
using System.Collections.Generic;

namespace PasswordEncryption.Data
{
    public interface IQueries
    {
        IEnumerable<UserDTO> GetUsers();
    }
}
