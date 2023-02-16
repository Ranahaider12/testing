using System.Threading.Tasks;
using Abp.Application.Services;
using testing.Sessions.Dto;

namespace testing.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
