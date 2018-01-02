using System.Threading.Tasks;
using AutoMapper;
using WebApi.Application;
using WebApi.Application.Dto;
using WebApi.Domain.Model;

namespace WebApi.Domain
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _UsersRepository;

        private readonly IMapper _Mapper;

        public UsersService(
            IUsersRepository usersRepository,
            IMapper mapper)
        {
            _UsersRepository = usersRepository;
            _Mapper = mapper;
        }

        public async Task<UserDto> GetUserById(string id)
        {
            var user = await _UsersRepository.GetUserById(id);
            return _Mapper.Map<User, UserDto>(user);
        }

        public void DeleteUserById(string id)
        {
            _UsersRepository.DeleteUserById(id);
        }
    }
}
