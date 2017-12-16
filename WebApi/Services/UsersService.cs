using System;
using WebApi.Repository;

namespace WebApi.Services
{
    public class UsersService : IUsersService
    {
        readonly IUsersRepository _UsersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _UsersRepository = usersRepository;
        }

        public async Task<UserDto> GetUserById(string id)
        {
            return await _UsersRepository.GetUserById(id);
            // chain format methods
        }
    }
}
