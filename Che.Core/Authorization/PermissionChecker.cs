using Abp.Authorization;
using Che.Authorization.Roles;
using Che.MultiTenancy;
using Che.Users;

namespace Che.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
