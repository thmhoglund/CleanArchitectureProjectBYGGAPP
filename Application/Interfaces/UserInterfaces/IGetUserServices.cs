using Application.DTOs.Account.Requests;
using Application.DTOs.Account.Responses;
using Application.Wrappers;
using System.Threading.Tasks;

namespace Application.Interfaces.UserInterfaces
{
    public interface IGetUserServices
    {
        Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model);
    }
}
