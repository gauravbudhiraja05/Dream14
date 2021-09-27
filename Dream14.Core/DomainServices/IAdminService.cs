using Dream14.ViewModels.Global;
using Dream14.ViewModels.SuperAdmin;
using System.Collections.Generic;

namespace Dream14.Core.DomainServices
{
    public interface IAdminService
    {
        #region Admin Users

        /// <summary>
        /// GetAllAdminUsers will return all end Users
        /// </summary>
        /// <returns>Admin User List</returns>
        IEnumerable<AdminUser> GetAllAdminUsers(int createdBy);

        /// <summary>
        /// Check UserName Exists
        /// </summary>
        /// <param name="emailAddress">emailAddress</param>
        /// <returns>Base result</returns>
        BaseResult CheckUserNameExists(string userName);

        /// <summary>
        /// Save Admin User
        /// </summary>
        /// <param name="user">AdminUser data structure</param>
        /// <returns>Base result</returns>
        BaseResult SaveAdminUser(AdminUser user);

        /// <summary>
        /// Get Admin User Detail
        /// </summary>
        /// <param name="id">Admin User Ide</param>
        /// <returns>Admin User Object</returns>
        AdminUser GetAdminUserById(int id);

        /// <summary>
        /// Update Admin User
        /// </summary>
        /// <param name="user">AdminUser data structure</param>
        /// <returns>Base result</returns>
        BaseResult UpdateAdminUser(AdminUser user);

        /// <summary>
        /// Delete Admin Users By Ids
        /// </summary>
        /// <param name="targetIds">DeleteItem data structure</param>
        /// <returns>Base result</returns>
        BaseResult ChangeAdminUserStatus(string status, int userId);

        #endregion

        #region Master Users

        /// <summary>
        /// GetAllMasterUsers will return all end Users
        /// </summary>
        /// <returns>Master User List</returns>
        IEnumerable<MasterUser> GetAllMasterUsers(int createdBy);

        ///// <summary>
        ///// Check Email Exists
        ///// </summary>
        ///// <param name="emailAddress">emailAddress</param>
        ///// <returns>Base result</returns>
        //BaseResult CheckEmailExist(string emailAddress);

        /// <summary>
        /// Save Master User
        /// </summary>
        /// <param name="user">AdminUser data structure</param>
        /// <returns>Base result</returns>
        BaseResult SaveMasterUser(MasterUser user);

        /// <summary>
        /// Get Master User Detail
        /// </summary>
        /// <param name="id">Admin User Ide</param>
        /// <returns>Admin User Object</returns>
        MasterUser GetMasterUserById(int id);

        /// <summary>
        /// Update Master User
        /// </summary>
        /// <param name="user">AdminUser data structure</param>
        /// <returns>Base result</returns>
        BaseResult UpdateMasterUser(MasterUser user);

        /// <summary>
        /// Delete Master Users By Ids
        /// </summary>
        /// <param name="targetIds">DeleteItem data structure</param>
        /// <returns>Base result</returns>
        BaseResult ChangeMasterUserStatus(string status, int userId);

        #endregion

        #region Agent Users

        /// <summary>
        /// GetAllAgentUsers will return all end Users
        /// </summary>
        /// <returns>Admin User List</returns>
        IEnumerable<AgentUser> GetAllAgentUsers(int createdBy);

        /// <summary>
        /// Save Agent User
        /// </summary>
        /// <param name="user">AdminUser data structure</param>
        /// <returns>Base result</returns>
        BaseResult SaveAgentUser(AgentUser user);

        /// <summary>
        /// Get Agent User Detail
        /// </summary>
        /// <param name="id">Admin User Ide</param>
        /// <returns>Admin User Object</returns>
        AgentUser GetAgentUserById(int id);

        /// <summary>
        /// Update Agent User
        /// </summary>
        /// <param name="user">AdminUser data structure</param>
        /// <returns>Base result</returns>
        BaseResult UpdateAgentUser(AgentUser user);

        /// <summary>
        /// Delete Agent Users By Ids
        /// </summary>
        /// <param name="targetIds">DeleteItem data structure</param>
        /// <returns>Base result</returns>
        BaseResult ChangeAgentUserStatus(string status, int userId);

        #endregion

        #region FrontEnd Users

        /// <summary>
        /// GetAllFrontEndUsers will return all end Users
        /// </summary>
        /// <returns>Admin User List</returns>
        IEnumerable<FrontEndUser> GetAllFrontEndUsers(int createdBy);

        ///// <summary>
        ///// Check Email Exists
        ///// </summary>
        ///// <param name="emailAddress">emailAddress</param>
        ///// <returns>Base result</returns>
        //BaseResult CheckEmailExist(string emailAddress);

        /// <summary>
        /// Save FrontEnd User
        /// </summary>
        /// <param name="user">AdminUser data structure</param>
        /// <returns>Base result</returns>
        BaseResult SaveFrontEndUser(FrontEndUser user);

        /// <summary>
        /// Get FrontEnd User Detail
        /// </summary>
        /// <param name="id">Admin User Ide</param>
        /// <returns>Admin User Object</returns>
        FrontEndUser GetFrontEndUserById(int id);

        /// <summary>
        /// Update FrontEnd User
        /// </summary>
        /// <param name="user">AdminUser data structure</param>
        /// <returns>Base result</returns>
        BaseResult UpdateFrontEndUser(FrontEndUser user);

        /// <summary>
        /// Delete FrontEnd Users By Ids
        /// </summary>
        /// <param name="targetIds">DeleteItem data structure</param>
        /// <returns>Base result</returns>
        BaseResult DeleteFrontEndUsersByIds(DeleteItem targetIds);

        #endregion

    }
}
