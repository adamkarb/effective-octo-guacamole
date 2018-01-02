using System;
using System.Threading.Tasks;
using WebApi.Application.Dto;
using WebApi.Domain.Model;
using WebApi.Infrastructure.Model;

namespace WebApi.Application
{
    public interface IUsersRepository
    {
        Task<User> GetUserById(string id);

        void DeleteUserById(string id);
    }
}
