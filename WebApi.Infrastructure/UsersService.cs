using System;
using System.Threading.Tasks;
using WebApi.Application;
using WebApi.Domain.Model;
using WebApi.Infrastructure;

namespace WebApi.Applicaiton
{
    public class UsersService : IUsersService
    {
        readonly IUsersRepository _UsersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _UsersRepository = usersRepository;
        }

        public async Task<User> GetUserById(string id)
        {
            return await _UsersRepository.GetUserById(id);
            // chain format methods
        }
    }
}
