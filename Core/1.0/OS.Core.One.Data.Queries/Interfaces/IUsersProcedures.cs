using OS.Core.One.Common.Intermediate;
using OS.Core.One.Data.Entities;
using System.Collections.Generic;

namespace OS.Core.One.Data.Queries
{
    public interface IUsersProcedures
    {
        IEnumerable<UserDTO> Get(SearchUsersRequest request);

        UserDTO GetById(int id);

        int Create(int userId, UserDTO request);

        bool Update(UserDTO request);

        bool Delete(DeleteUsersRequest request);
    }
}
