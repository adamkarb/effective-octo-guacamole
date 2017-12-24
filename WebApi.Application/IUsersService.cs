using System;
using System.Threading.Tasks;
using WebApi.Domain.Model;

namespace WebApi.Application
{
    public interface IUsersService
    {
        Task<User> GetUserById(string id);
    }
}
