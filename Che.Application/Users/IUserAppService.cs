using System.Threading.Tasks;
using Abp.Application.Services;
using Che.Users.Dto;

namespace Che.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}