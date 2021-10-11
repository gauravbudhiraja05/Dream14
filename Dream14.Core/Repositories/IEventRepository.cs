using System.Collections.Generic;
using Dream14.ViewModels.Global;

namespace Dream14.Core.Repositories
{
    public interface IEventRepository
    {
        List<string> GetSelectedGameIds(string query);

        BaseResult ChangeEventStatus(string query, object param);
    }
}
