using Abp.Application.Features;
using Che.Authorization.Roles;
using Che.MultiTenancy;
using Che.Users;

namespace Che.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}