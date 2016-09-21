using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OS.Core.One.Common.Intermediate;
using OS.Core.One.Business;
using OS.Core.One.Business.Entities;

namespace OS.Web.API.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _usersService.Get(new SearchUsersRequest { Keyword = string.Empty });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
