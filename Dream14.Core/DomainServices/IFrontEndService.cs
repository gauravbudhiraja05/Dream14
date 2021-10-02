using Dream14.ViewModels.Global;

namespace Dream14.Core.DomainServices
{
    public interface IFrontEndService
    {
        BaseResult CheckOldPassword(string oldPassword, int userId);
        BaseResult ChangePassword(string NewPassword, int userId);
    }
}
