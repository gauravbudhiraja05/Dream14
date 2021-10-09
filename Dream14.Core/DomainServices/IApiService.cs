using Dream14.ViewModels.Global;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dream14.Core.DomainServices
{
    public interface IApiService
    {
        Task<List<Cricket>>  GetApiListAsync();

        Task<EventDetail> GetEventDetailAsync(string gameId);
    }
}
