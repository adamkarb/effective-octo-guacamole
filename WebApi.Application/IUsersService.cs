using System.Threading.Tasks;
using WebApi.Application.Dto;

namespace WebApi.Application
{
    public interface IUsersService
    {
        Task<UserDto> GetUserById(string id);

        void DeleteUserById(string id);
    }
}
