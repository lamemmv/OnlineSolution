using Microsoft.AspNetCore.Mvc;
using OS.Core.One.Business;
using OS.Core.One.Business.Entities;
using OS.Core.One.Common.Intermediate;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

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
        public async Task<IEnumerable<User>> Get([FromUri]SearchUsersRequest request)
        {
            return await Task.FromResult(_usersService.Get(request));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return new OkObjectResult(_usersService.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<int> Post([FromUri]User request)
        {
            return await Task.FromResult(_usersService.Create(1, request));
        }

        // PUT api/values
        [HttpPut]
        public async Task<bool> Put(User request)
        {
            return await Task.FromResult(_usersService.Update(request));
        }

        // DELETE api/values/5
        [HttpDelete]
        public async Task<bool> Delete([FromUri]DeleteUsersRequest request)
        {
            return await Task.FromResult(_usersService.Delete(request));
        }
    }
}
