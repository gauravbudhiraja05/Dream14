using Dream14.Core.DomainServices;
using Dream14.Core.Repositories;
using Dream14.ViewModels.Global;
using System;
using System.Collections.Generic;

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
                return _unitOfWork.FrontEndRepo.CheckOldPassword("usp_CheckOldPassword", new { oldPassword, userId });
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
                return _unitOfWork.FrontEndRepo.ChangePassword("usp_ChangePassword", new { NewPassword, userId });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, string> GetUserBetButtonValue(int userId)
        {
            try
            {
                return _unitOfWork.FrontEndRepo.GetUserBetButtonValue("usp_GetUserBetButtonValue", new { userId });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateUserBetValue(string betValue, string stakeValue, string type, string gameId, string teamName, int userId)
        {
            try
            {
                return _unitOfWork.FrontEndRepo.UpdateUserBetValue("usp_AddOrUpdateUserBetValue", new { betValue, stakeValue, userId, type, teamName, gameId });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetUserStakeValue(string type, string gameId, string teamName, int userId)
        {
            try
            {
                return _unitOfWork.FrontEndRepo.GetUserStakeValue("usp_GetUserStakeValue", new { userId, type, teamName, gameId });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetUserStakeValue_New(string type, string gameId, int userId)
        {
            try
            {
                return _unitOfWork.FrontEndRepo.GetUserStakeValue("usp_GetUserStakeValue_New", new { userId, type, gameId });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateBetButtonValue(Dictionary<string, string> btnValueList, int userId)
        {
            try
            {
                return _unitOfWork.FrontEndRepo.UpdateBetButtonValue("usp_AddorUpdateBetButtonValue", new
                {

                    btn1lbl = btnValueList["Button1"].Split(':', StringSplitOptions.RemoveEmptyEntries)[0],
                    btn1Value = btnValueList["Button1"].Split(':', StringSplitOptions.RemoveEmptyEntries)[1],
                    
                    btn2lbl = btnValueList["Button2"].Split(':', StringSplitOptions.RemoveEmptyEntries)[0],
                    btn2Value = btnValueList["Button2"].Split(':', StringSplitOptions.RemoveEmptyEntries)[1],
                    
                    btn3lbl = btnValueList["Button3"].Split(':', StringSplitOptions.RemoveEmptyEntries)[0],
                    btn3Value = btnValueList["Button3"].Split(':', StringSplitOptions.RemoveEmptyEntries)[1],
                    
                    btn4lbl = btnValueList["Button4"].Split(':', StringSplitOptions.RemoveEmptyEntries)[0],
                    btn4Value = btnValueList["Button4"].Split(':', StringSplitOptions.RemoveEmptyEntries)[1],
                    
                    btn5lbl = btnValueList["Button5"].Split(':', StringSplitOptions.RemoveEmptyEntries)[0],
                    btn5Value = btnValueList["Button5"].Split(':', StringSplitOptions.RemoveEmptyEntries)[1],
                    
                    btn6lbl = btnValueList["Button6"].Split(':', StringSplitOptions.RemoveEmptyEntries)[0],
                    btn6Value = btnValueList["Button6"].Split(':', StringSplitOptions.RemoveEmptyEntries)[1],
                    
                    btn7lbl = btnValueList["Button7"].Split(':', StringSplitOptions.RemoveEmptyEntries)[0],
                    btn7Value = btnValueList["Button7"].Split(':', StringSplitOptions.RemoveEmptyEntries)[1],
                    
                    btn8lbl = btnValueList["Button8"].Split(':', StringSplitOptions.RemoveEmptyEntries)[0],
                    btn8Value = btnValueList["Button8"].Split(':', StringSplitOptions.RemoveEmptyEntries)[1],
                    
                    btn9lbl = btnValueList["Button9"].Split(':', StringSplitOptions.RemoveEmptyEntries)[0],
                    btn9Value = btnValueList["Button9"].Split(':', StringSplitOptions.RemoveEmptyEntries)[1],
                    
                    btn10lbl = btnValueList["Button10"].Split(':', StringSplitOptions.RemoveEmptyEntries)[0],
                    btn10Value = btnValueList["Button10"].Split(':', StringSplitOptions.RemoveEmptyEntries)[1],



                    userId
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
