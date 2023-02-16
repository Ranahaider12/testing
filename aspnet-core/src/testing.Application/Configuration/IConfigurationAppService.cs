using System.Threading.Tasks;
using testing.Configuration.Dto;

namespace testing.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
