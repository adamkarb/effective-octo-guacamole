using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Domain.Model;
using WebApi.Application;
using WebApi.Application.Dto;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _UsersService;

        public UsersController(IUsersService usersService)
        {
            _UsersService = usersService;
        }

        //// GET /users
        //[HttpGet]
        //public async Task<IActionResult> GetUsers()
        //{
        //    // Fetch all applicable users
        //}

        // GET /users/{id}
        [HttpGet("{id}")]
        public Task<UserDto> GetUser(string id) => _UsersService.GetUserById(id);

        // POST /users
        [HttpPost]
        public void Post([FromBody]UserDto user)
        {
            
        }

        //// PUT /users/{id}
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]User user)
        //{
        //    // Update a user based on user in put body
        //}

        // DELETE /users/{id}
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _UsersService.DeleteUserById(id);
        }
    }
}
