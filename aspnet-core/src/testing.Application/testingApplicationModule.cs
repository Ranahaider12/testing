using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using testing.Authorization;

namespace testing
{
    [DependsOn(
        typeof(testingCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class testingApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<testingAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(testingApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
