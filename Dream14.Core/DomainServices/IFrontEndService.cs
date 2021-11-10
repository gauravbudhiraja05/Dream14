using System.Collections.Generic;
using Dream14.ViewModels.Global;

namespace Dream14.Core.DomainServices
{
    public interface IFrontEndService
    {
        BaseResult CheckOldPassword(string oldPassword, int userId);
        BaseResult ChangePassword(string NewPassword, int userId);
        Dictionary<string, string> GetUserBetButtonValue(int userId);
        BaseResult UpdateUserBetValue(string betValue, string stakeValue, string type, string gameId, string teamName, int userId);
        string GetUserStakeValue(string type, string gameId, string teamName, int userId);
        string GetUserStakeValue_New(string type, string gameId, int userId);
        BaseResult UpdateBetButtonValue(Dictionary<string, string> btnValueList, int userId);
    }
}
