using InstantRepairOrderV1.Application.Common.Models;
using System.Threading.Tasks;

namespace InstantRepairOrderV1.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);

        Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);

        Task<Result> DeleteUserAsync(string userId);
    }
}
