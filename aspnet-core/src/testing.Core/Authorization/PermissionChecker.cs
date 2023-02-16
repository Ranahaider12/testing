using Abp.Authorization;
using testing.Authorization.Roles;
using testing.Authorization.Users;

namespace testing.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
