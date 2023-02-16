using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using testing.EntityFrameworkCore;
using testing.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace testing.Web.Tests
{
    [DependsOn(
        typeof(testingWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class testingWebTestModule : AbpModule
    {
        public testingWebTestModule(testingEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(testingWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(testingWebMvcModule).Assembly);
        }
    }
}