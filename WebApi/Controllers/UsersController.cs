using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;
using WebApi.Domain.Model;
using WebApi.Domain;
using WebApi.Application;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _UsersService;

        public UsersController(IUsersService usersService)
        {
            _UsersService = usersService;
        }

        // GET api/users/{id}
        [HttpGet("{id}")]
        public Task<User> Get(string id)
        {
            return _UsersService.GetUserById(id);
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody]User user)
        {
            // Create a user based on user in post body
        }

        // PUT api/users/{id}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]User user)
        {
            // Update a user based on user in put body
        }

        // DELETE api/users/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // Delete user from db with id
        }
    }
}
