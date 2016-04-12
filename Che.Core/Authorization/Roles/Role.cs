using Abp.Authorization.Roles;
using Che.MultiTenancy;
using Che.Users;

namespace Che.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}