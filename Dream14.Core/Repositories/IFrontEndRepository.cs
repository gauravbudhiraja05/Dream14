using System.Collections.Generic;
using Dream14.ViewModels.Global;

namespace Dream14.Core.Repositories
{
    public interface IFrontEndRepository
    {
        BaseResult CheckOldPassword(string query, object param);

        BaseResult ChangePassword(string query, object param);

        Dictionary<string, string> GetUserBetButtonValue(string query, object param);

        BaseResult UpdateUserBetValue(string query, object param);

        string GetUserStakeValue(string query, object param);

        BaseResult UpdateBetButtonValue(string query, object param);
    }
}
