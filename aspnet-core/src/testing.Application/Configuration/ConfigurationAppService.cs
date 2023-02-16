using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using testing.Configuration.Dto;

namespace testing.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : testingAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
