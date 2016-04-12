using System.Threading.Tasks;
using Abp.Application.Services;
using Che.Roles.Dto;

namespace Che.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
