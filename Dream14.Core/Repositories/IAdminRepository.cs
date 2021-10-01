using Dream14.ViewModels.FrontEnd;
using Dream14.ViewModels.Global;
using Dream14.ViewModels.SuperAdmin;
using System.Collections.Generic;

namespace Dream14.Core.Repositories
{
    public interface IAdminRepository
    {
        bool CheckValidOldPassword(string query, object param);

        BaseResult ChangePasswordForLoginUser(string query, object param);

        DepsoitWithDrawl GetAmountDetail(string query, object param);

        BaseResult SaveAmountDetail(string query, object param);

        BaseResult AddUserDetail(string query, object param);

        int GetUserCount(string query);

        IEnumerable<UserDetail> GetUserList(string query);

        BaseResult ChangeUserStatus(string query, object param);


        #region Admin User

        /// <summary>
        /// Get All AdminUsers
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <returns>Admin User List</returns>
        IEnumerable<AdminUser> GetAllAdminUsers(string query, object param);

        /// <summary>
        /// Check Email Exist
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        BaseResult CheckUserNameExists(string query, object param);

        /// <summary>
        /// Save Admin user
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        BaseResult SaveAdminUser(string query, object param);

        /// <summary>
        /// Get Admin USer By Id
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        AdminUser GetAdminUserById(string query, object param);

        /// <summary>
        /// Update Admin user
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        BaseResult UpdateAdminUser(string query, object param);

        /// <summary>
        /// Delete Admin Users By Ids
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        BaseResult ChangeAdminUserStatus(string query, object param);

        #endregion

        #region Master User

        /// <summary>
        /// Get All Master Users
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <returns>Master User List</returns>
        IEnumerable<MasterUser> GetAllMasterUsers(string query, object param);

        ///// <summary>
        ///// Check Email Exist
        ///// </summary>
        ///// <param name="query">procedure name</param>
        ///// <param name="param">paramters object</param>
        ///// <returns>true/false</returns>
        //BaseResult CheckEmailExist(string query, object param);

        /// <summary>
        /// Save Master user
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        BaseResult SaveMasterUser(string query, object param);

        /// <summary>
        /// Get Master USer By Id
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        MasterUser GetMasterUserById(string query, object param);

        /// <summary>
        /// Update Master user
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        BaseResult UpdateMasterUser(string query, object param);

        /// <summary>
        /// Delete Master Users By Ids
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        BaseResult ChangeMasterUserStatus(string query, object param);

        #endregion

        #region Agent User

        /// <summary>
        /// Get All Agent Users
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <returns>Agent User List</returns>
        IEnumerable<AgentUser> GetAllAgentUsers(string query, object param);

        ///// <summary>
        ///// Check Email Exist
        ///// </summary>
        ///// <param name="query">procedure name</param>
        ///// <param name="param">paramters object</param>
        ///// <returns>true/false</returns>
        //BaseResult CheckEmailExist(string query, object param);

        /// <summary>
        /// Save Agent user
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        BaseResult SaveAgentUser(string query, object param);

        /// <summary>
        /// Get Agent USer By Id
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        AgentUser GetAgentUserById(string query, object param);

        /// <summary>
        /// Update Agent user
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        BaseResult UpdateAgentUser(string query, object param);

        /// <summary>
        /// Delete Agent Users By Ids
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        BaseResult ChangeAgentUserStatus(string query, object param);

        #endregion

        #region FrontEnd User

        /// <summary>
        /// Get All FrontEnd Users
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <returns>FrontEnd User List</returns>
        IEnumerable<FrontEndUser> GetAllFrontEndUsers(string query, object param);

        ///// <summary>
        ///// Check Email Exist
        ///// </summary>
        ///// <param name="query">procedure name</param>
        ///// <param name="param">paramters object</param>
        ///// <returns>true/false</returns>
        //BaseResult CheckEmailExist(string query, object param);

        /// <summary>
        /// Save FrontEnd user
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        BaseResult SaveFrontEndUser(string query, object param);

        /// <summary>
        /// Get FrontEnd USer By Id
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        FrontEndUser GetFrontEndUserById(string query, object param);

        /// <summary>
        /// Update FrontEnd user
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        BaseResult UpdateFrontEndUser(string query, object param);

        /// <summary>
        /// Delete FrontEnd Users By Ids
        /// </summary>
        /// <param name="query">procedure name</param>
        /// <param name="param">paramters object</param>
        /// <returns>true/false</returns>
        BaseResult ChangeFrontEndUserStatus(string query, object param);

        #endregion
    }
}
