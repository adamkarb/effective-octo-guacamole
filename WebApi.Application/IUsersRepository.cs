using System;
using System.Threading.Tasks;
using WebApi.Domain.Model;
using WebApi.Infrastructure.Model;

namespace WebApi.Application
{
    public interface IUsersRepository
    {
        Task<UserSqlModel> GetUserById(string id);
    }
}
