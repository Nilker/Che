using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Che.MultiTenancy.Dto;

namespace Che.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
