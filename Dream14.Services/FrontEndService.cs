using Dream14.Core.DomainServices;
using Dream14.Core.Repositories;
using Dream14.ViewModels.Global;
using System;

namespace Dream14.Services
{
    public class FrontEndService : IFrontEndService
    {
        #region Private Properties

        /// <summary>
        /// Private IUnitOfWork Data Member
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Constructor

        /// <summary>
        /// FrontEndService Constructor
        /// </summary>
        /// <param name="unitOfWork">IUnitOfWork</param>
        public FrontEndService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion

        public BaseResult CheckOldPassword(string oldPassword, int userId)
        {
            try
            {
                BaseResult result = _unitOfWork.FrontEndRepo.CheckOldPassword("usp_CheckOldPassword", new { oldPassword, userId });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult ChangePassword(string NewPassword, int userId)
        {
            try
            {
                BaseResult result = _unitOfWork.FrontEndRepo.ChangePassword("usp_ChangePassword", new { NewPassword, userId });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
