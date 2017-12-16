using System;
using System.Data;
using System.Threading.Tasks;

namespace WebApi.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IDbConnection _DbConnection;

        public UsersRepository(IDbConnection DbConnection)
        {
            _DbConnection = DbConnection;
        }

        public async Task<UserDto> GetUserById(string id)
        {
            // return user with id
        }
    }
}
