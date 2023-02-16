using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace testing.Controllers
{
    public abstract class testingControllerBase: AbpController
    {
        protected testingControllerBase()
        {
            LocalizationSourceName = testingConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
