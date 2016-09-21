﻿using OS.Core.One.Business.Entities;
using OS.Core.One.Common.Intermediate;
using System.Collections.Generic;

namespace OS.Core.One.Business
{
    public interface IInternalUsersService
    {
        IEnumerable<User> Get(SearchUsersRequest request);
    }
}
