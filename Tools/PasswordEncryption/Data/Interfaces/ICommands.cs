using PasswordEncryption.Entities;
using System.Collections.Generic;

namespace PasswordEncryption.Data
{
    public interface ICommands
    {
        bool UpdatePassword(UserDTO request);
        bool UpdatePasswords(IEnumerable<UserDTO> request);
    }
}
