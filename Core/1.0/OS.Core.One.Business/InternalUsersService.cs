using System.Collections.Generic;
using OS.Core.One.Business.Entities;
using OS.Core.One.Common.Intermediate;
using OS.Core.One.Data.Queries;
using System.Linq;

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
    }
}
