using System;
using System.Data;
using System.Threading.Tasks;
using WebApi.Application;
using WebApi.Domain.Model;

namespace WebApi.Infrastructure
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IDbConnection _DbConnection;

        public UsersRepository(IDbConnection DbConnection)
        {
            _DbConnection = DbConnection;
        }

        public async Task<User> GetUserById(string id)
        {
            // return user with id
        }
    }
}
