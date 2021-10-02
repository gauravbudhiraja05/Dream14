using Dream14.ViewModels.Global;

namespace Dream14.Core.Repositories
{
    public interface IFrontEndRepository
    {
        BaseResult CheckOldPassword(string query, object param);

        BaseResult ChangePassword(string query, object param);
    }
}
