using System.Data;
using System.Threading.Tasks;
using WebApi.Application;
using WebApi.Domain.Model;
using Npgsql;
using Dapper;
using WebApi.Infrastructure.Model;
using WebApi.configuration;
using Microsoft.Extensions.Options;
using AutoMapper;

namespace WebApi.Infrastructure
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AppSettings _AppSettings;

        private readonly IMapper _Mapper;

        public UsersRepository(IOptions<AppSettings> appSettings, IMapper mapper)
        {
            _AppSettings = appSettings.Value;
            _Mapper = mapper;
        }

        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(_AppSettings.ConnectionStrings.SqlConnection);
            }
        }

        public async Task<User> GetUserById(string id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                var query = "SELECT * FROM Users WHERE UserID=@userId";

                var parameters = new
                {
                    userId = id
                };

                dbConnection.Open();
                var userSql =  await dbConnection.QuerySingleOrDefaultAsync<UserSqlModel>(query, parameters);

                return _Mapper.Map<UserSqlModel, User>(userSql);
            }
        }

        public void DeleteUserById(string id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                var query = "DELETE FROM Users WHERE UserID=@userId";

                var parameters = new
                {
                    userId = id
                };

                dbConnection.Open();
                dbConnection.QueryAsync(query, parameters);
            }
        }
    }
}
