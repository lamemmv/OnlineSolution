using OS.Core.One.Business.Entities;
using OS.Core.One.Common.Intermediate;
using System.Collections.Generic;

namespace OS.Core.One.Business.Security
{
    public class SecureUsersService : IUsersService
    {
        private readonly IInternalUsersService _internalUsersService;

        public SecureUsersService(IInternalUsersService cachedUsersService)
        {
            _internalUsersService = cachedUsersService;
        }

        public IEnumerable<User> Get(SearchUsersRequest request)
        {
            return _internalUsersService.Get(request);
        }

        public User GetById(int id)
        {
            return _internalUsersService.GetById(id);
        }

        public int Create(int userId, User request)
        {
            return _internalUsersService.Create(userId, request);
        }

        public bool Update(User request)
        {
            return _internalUsersService.Update(request);
        }

        public bool Delete(DeleteUsersRequest request)
        {
            return _internalUsersService.Delete(request);
        }
    }
}
