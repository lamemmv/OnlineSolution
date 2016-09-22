using System.Collections.Generic;
using OS.Core.One.Business.Entities;
using OS.Core.One.Common.Intermediate;
using OS.Core.One.Data.Queries;
using System.Linq;
using OS.Core.One.Data.Entities;

namespace OS.Core.One.Business
{
    public class InternalUsersService : IInternalUsersService
    {
        private readonly IUsersProcedures _usersProcedures;

        public InternalUsersService(IUsersProcedures usersProcedures)
        {
            _usersProcedures = usersProcedures;
        }

        public IEnumerable<User> Get(SearchUsersRequest request)
        {
            return _usersProcedures.Get(request).Select(x => x.ToDomain());
        }

        public User GetById(int id)
        {
            return _usersProcedures.GetById(id).ToDomain();
        }

        public int Create(int userId, User request)
        {
            return _usersProcedures.Create(userId, new UserDTO(request));
        }

        public bool Update(User request)
        {
            return _usersProcedures.Update(new UserDTO(request));
        }        

        public bool Delete(DeleteUsersRequest request)
        {
            return _usersProcedures.Delete(request);
        }
    }
}
