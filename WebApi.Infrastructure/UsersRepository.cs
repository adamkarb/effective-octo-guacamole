using System;
using System.Data;
using System.Threading.Tasks;
using WebApi.Application;
using WebApi.Domain.Model;
using Npgsql;
using Dapper;
using Microsoft.Extensions.Configuration;
using WebApi.Infrastructure.Model;

namespace WebApi.Infrastructure
{
    public class UsersRepository : IUsersRepository
    {
        private string connectionString;

        public UsersRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultSqlConnection");
        }

        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(connectionString);
            }
        }

        public Task<UserSqlModel> GetUserById(string id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                var query = "SELECT * FROM Users WHERE UserID=@userId";
                var parameters = new
                {
                    userId = id
                };
                dbConnection.Open();
                return dbConnection.QuerySingleOrDefaultAsync<UserSqlModel>(query, parameters);
            }
        }
    }
}
