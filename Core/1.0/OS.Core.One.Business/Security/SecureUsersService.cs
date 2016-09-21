using System.Collections.Generic;
using OS.Core.One.Business.Entities;
using OS.Core.One.Common.Intermediate;

namespace OS.Core.One.Business.Security
{
    public class SecureUsersService : IUsersService
    {
        private readonly IInternalUsersService _cachedUsersService;

        public SecureUsersService(IInternalUsersService cachedUsersService)
        {
            _cachedUsersService = cachedUsersService;
        }

        public IEnumerable<User> Get(SearchUsersRequest request)
        {
            return _cachedUsersService.Get(request);
        }
    }
}
