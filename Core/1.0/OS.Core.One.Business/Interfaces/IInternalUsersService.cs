using OS.Core.One.Business.Entities;
using OS.Core.One.Common.Intermediate;
using System.Collections.Generic;

namespace OS.Core.One.Business
{
    public interface IInternalUsersService
    {
        IEnumerable<User> Get(SearchUsersRequest request);

        User GetById(int id);

        int Create(int userId, User request);

        bool Update(User request);

        bool Delete(DeleteUsersRequest request);
    }
}
