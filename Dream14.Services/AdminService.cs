using Dream14.Core.DomainServices;
using Dream14.Core.Repositories;
using Dream14.ViewModels.FrontEnd;
using Dream14.ViewModels.Global;
using Dream14.ViewModels.SuperAdmin;
using System;
using System.Collections.Generic;

namespace Dream14.Services
{
    public class AdminService : IAdminService
    {

        #region Private Properties

        /// <summary>
        /// Private IUnitOfWork Data Member
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Constructor

        /// <summary>
        /// AdminService Constructor
        /// </summary>
        /// <param name="unitOfWork">IUnitOfWork</param>
        public AdminService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion

        public bool CheckValidOldPassword(string password, int userId)
        {
            try
            {
                bool result = _unitOfWork.AdminRepo.CheckValidOldPassword("usp_CheckValidOldPassword", new { password, userId });
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public BaseResult ChangePasswordForLoginUser(string newPassword, int userId)
        {
            try
            {
                BaseResult result = _unitOfWork.AdminRepo.ChangePasswordForLoginUser("usp_ChangePasswordForLoginUser", new { newPassword, userId });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DepsoitWithDrawl GetAmountDetail(int userId)
        {
            try
            {
                DepsoitWithDrawl result = _unitOfWork.AdminRepo.GetAmountDetail("usp_GetAmountDetail", new { userId });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult SaveAmountDetail(DepsoitWithDrawl depsoitWithDrawl)
        {
            try
            {
                BaseResult result = _unitOfWork.AdminRepo.SaveAmountDetail("usp_SaveAmountDetail", new { depsoitWithDrawl.UserId, depsoitWithDrawl.Balance, depsoitWithDrawl.Deposit, depsoitWithDrawl.WithDrawl });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult AddUserDetail(UserDetail userDetail)
        {
            try
            {
                BaseResult result = _unitOfWork.AdminRepo.AddUserDetail("usp_AddUserDetail", new { userDetail.Name, userDetail.MobileNumber1, userDetail.MobileNumber2, userDetail.City, userDetail.State, userDetail.Country });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetUserCount()
        {
            try
            {
                int result = _unitOfWork.AdminRepo.GetUserCount("usp_GetUserCount");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<UserDetail> GetUserList()
        {
            try
            {
                var result = _unitOfWork.AdminRepo.GetUserList("usp_GetUserList");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult ChangeUserStatus(int id)
        {
            try
            {
                var result = _unitOfWork.AdminRepo.ChangeUserStatus("usp_ChangeUserStatus", new { id });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #region Admin Users

        public IEnumerable<AdminUser> GetAllAdminUsers(int createdBy)
        {
            return _unitOfWork.AdminRepo.GetAllAdminUsers("usp_GetAllAdminUsers", new { createdBy });
        }

        public BaseResult CheckUserNameExists(string userName)
        {
            return _unitOfWork.AdminRepo.CheckUserNameExists("usp_CheckUserNameExist", new { userName });
        }

        public BaseResult SaveAdminUser(AdminUser adminUser)
        {
            try
            {
                return _unitOfWork.AdminRepo.SaveAdminUser("usp_AddAdminUser", new
                {
                    adminUser.Name,
                    adminUser.UserName,
                    adminUser.Password,
                    adminUser.RoleName,
                    adminUser.MobileNumber,
                    adminUser.UserType,
                    adminUser.CreatedBy
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public AdminUser GetAdminUserById(int Id)
        {
            try
            {
                return _unitOfWork.AdminRepo.GetAdminUserById("usp_GetAdminUserById", new { id = Id });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BaseResult UpdateAdminUser(AdminUser adminUser)
        {
            try
            {
                return _unitOfWork.AdminRepo.UpdateAdminUser("usp_UpdateAdminUser", new
                {
                    adminUser.UserId,
                    adminUser.Name,
                    adminUser.UserName,
                    adminUser.Password,
                    adminUser.MobileNumber,
                    adminUser.UserType,
                    adminUser.ModifiedBy,
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BaseResult ChangeAdminUserStatus(string status, int userId)
        {
            try
            {
                return _unitOfWork.AdminRepo.ChangeAdminUserStatus("usp_ChangeAdminUserStatus", new
                {
                    status,
                    userId,
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Master Users

        public IEnumerable<MasterUser> GetAllMasterUsers(int createdBy)
        {
            return _unitOfWork.AdminRepo.GetAllMasterUsers("usp_GetAllMasterUsers", new { createdBy });
        }

        public BaseResult SaveMasterUser(MasterUser masterUser)
        {
            try
            {
                return _unitOfWork.AdminRepo.SaveMasterUser("usp_AddMasterUser", new
                {
                    masterUser.Name,
                    masterUser.UserName,
                    masterUser.Password,
                    masterUser.RoleName,
                    masterUser.MobileNumber,
                    masterUser.UserType,
                    masterUser.CreatedBy
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public MasterUser GetMasterUserById(int Id)
        {
            try
            {
                return _unitOfWork.AdminRepo.GetMasterUserById("usp_GetMasterUserById", new { id = Id });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BaseResult UpdateMasterUser(MasterUser masterUser)
        {
            try
            {
                return _unitOfWork.AdminRepo.UpdateMasterUser("usp_UpdateMasterUser", new
                {
                    masterUser.UserId,
                    masterUser.Name,
                    masterUser.UserName,
                    masterUser.Password,
                    masterUser.MobileNumber,
                    masterUser.UserType,
                    masterUser.ModifiedBy,
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BaseResult ChangeMasterUserStatus(string status, int userId)
        {
            try
            {
                return _unitOfWork.AdminRepo.ChangeMasterUserStatus("usp_ChangeMasterUserStatus", new
                {
                    status,
                    userId,
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Agent Users

        public IEnumerable<AgentUser> GetAllAgentUsers(int createdBy)
        {
            return _unitOfWork.AdminRepo.GetAllAgentUsers("usp_GetAllAgentUsers", new { createdBy });
        }

        public BaseResult SaveAgentUser(AgentUser agentUser)
        {
            try
            {
                return _unitOfWork.AdminRepo.SaveAgentUser("usp_AddAgentUser", new
                {
                    agentUser.Name,
                    agentUser.UserName,
                    agentUser.Password,
                    agentUser.RoleName,
                    agentUser.MobileNumber,
                    agentUser.UserType,
                    agentUser.CreatedBy
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public AgentUser GetAgentUserById(int Id)
        {
            try
            {
                return _unitOfWork.AdminRepo.GetAgentUserById("usp_GetAgentUserById", new { id = Id });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BaseResult UpdateAgentUser(AgentUser agentUser)
        {
            try
            {
                return _unitOfWork.AdminRepo.UpdateAgentUser("usp_UpdateAgentUser", new
                {
                    agentUser.UserId,
                    agentUser.Name,
                    agentUser.UserName,
                    agentUser.Password,
                    agentUser.MobileNumber,
                    agentUser.UserType,
                    agentUser.ModifiedBy,
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BaseResult ChangeAgentUserStatus(string status, int userId)
        {
            try
            {
                return _unitOfWork.AdminRepo.ChangeAgentUserStatus("usp_ChangeAgentUserStatus", new
                {
                    status,
                    userId,
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region FrontEnd Users

        public IEnumerable<FrontEndUser> GetAllFrontEndUsers(int createdBy)
        {
            return _unitOfWork.AdminRepo.GetAllFrontEndUsers("usp_GetAllFrontEndUsers", new { createdBy });
        }

        public BaseResult SaveFrontEndUser(FrontEndUser frontEndUser)
        {
            try
            {
                return _unitOfWork.AdminRepo.SaveFrontEndUser("usp_AddFrontEndUser", new
                {
                    frontEndUser.Name,
                    frontEndUser.UserName,
                    frontEndUser.Password,
                    frontEndUser.RoleName,
                    frontEndUser.MobileNumber,
                    frontEndUser.CreatedBy
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public FrontEndUser GetFrontEndUserById(int Id)
        {
            try
            {
                return _unitOfWork.AdminRepo.GetFrontEndUserById("usp_GetFrontEndUserById", new { id = Id });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BaseResult UpdateFrontEndUser(FrontEndUser frontEndUser)
        {
            try
            {
                return _unitOfWork.AdminRepo.UpdateFrontEndUser("usp_UpdateFrontEndUser", new
                {
                    frontEndUser.UserId,
                    frontEndUser.Name,
                    frontEndUser.UserName,
                    frontEndUser.Password,
                    frontEndUser.MobileNumber,
                    frontEndUser.ModifiedBy,
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BaseResult ChangeFrontEndUserStatus(string status, int userId)
        {
            try
            {
                return _unitOfWork.AdminRepo.ChangeFrontEndUserStatus("usp_ChangeFrontEndUserStatus", new
                {
                    status,
                    userId,
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
