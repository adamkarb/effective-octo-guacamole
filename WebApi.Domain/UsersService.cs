using System;
using System.Threading.Tasks;
using AutoMapper;
using WebApi.Application;
using WebApi.Domain.Model;
using WebApi.Infrastructure;
using WebApi.Infrastructure.Model;

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

        public async Task<User> GetUserById(string id)
        {
            var userSql = await _UsersRepository.GetUserById(id);
            return _Mapper.Map<UserSqlModel, User>(userSql);
        }
    }
}
