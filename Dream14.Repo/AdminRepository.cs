using Dapper;
using Dream14.Core.Helper;
using Dream14.Core.Repositories;
using Dream14.ViewModels.Global;
using Dream14.ViewModels.SuperAdmin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Dream14.Repo
{
    public class AdminRepository : Repository, IAdminRepository
    {

        #region Constructor

        /// <summary>
        /// AdminRepository Constructor
        /// </summary>
        /// <param name="context">Database Context</param>
        public AdminRepository(IDbConnection connection) : base(connection)
        {

        }

        #endregion

        #region Public Properites

        /// <summary>
        /// Database Connection
        /// </summary>
        public IDbConnection DatabaseConnection
        {
            get { return Connection; }
        }

        #endregion

        #region Admin Users

        public IEnumerable<AdminUser> GetAllAdminUsers(string query, object param)
        {
            try
            {
                var adminUserList = Connection.Query<AdminUser>(query, param, commandType: CommandType.StoredProcedure).ToList();
                return adminUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult CheckUserNameExists(string query, object param)
        {
            try
            {
                var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult SaveAdminUser(string query, object param)
        {
            try
            {
                var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AdminUser GetAdminUserById(string query, object param)
        {
            try
            {
                var adminUser = ExecuteQuery<AdminUser>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault(); ;
                return adminUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateAdminUser(string query, object param)
        {
            try
            {
                var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult ChangeAdminUserStatus(string query, object param)
        {
            try
            {
                var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Master Users

        public IEnumerable<MasterUser> GetAllMasterUsers(string query, object param)
        {
            try
            {
                var masterUserList = Connection.Query<MasterUser>(query, param, commandType: CommandType.StoredProcedure).ToList();
                return masterUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult SaveMasterUser(string query, object param)
        {
            try
            {
                var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MasterUser GetMasterUserById(string query, object param)
        {
            try
            {
                var masterUser = ExecuteQuery<MasterUser>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault(); ;
                return masterUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateMasterUser(string query, object param)
        {
            try
            {
                var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult ChangeMasterUserStatus(string query, object param)
        {
            try
            {
                var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Agent Users

        public IEnumerable<AgentUser> GetAllAgentUsers(string query, object param)
        {
            try
            {
                var agentUserList = Connection.Query<AgentUser>(query, param, commandType: CommandType.StoredProcedure).ToList();
                return agentUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult SaveAgentUser(string query, object param)
        {
            try
            {
                var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AgentUser GetAgentUserById(string query, object param)
        {
            try
            {
                var agentUser = ExecuteQuery<AgentUser>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault(); ;
                return agentUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateAgentUser(string query, object param)
        {
            try
            {
                var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult ChangeAgentUserStatus(string query, object param)
        {
            try
            {
                var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region FrontEnd Users

        public IEnumerable<FrontEndUser> GetAllFrontEndUsers(string query, object param)
        {
            try
            {
                var frontEndUserList = Connection.Query<FrontEndUser>(query, param, commandType: CommandType.StoredProcedure).ToList();
                return frontEndUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public BaseResult CheckEmailExist(string query, object param)
        //{
        //    try
        //    {
        //        var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public BaseResult SaveFrontEndUser(string query, object param)
        {
            try
            {
                var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FrontEndUser GetFrontEndUserById(string query, object param)
        {
            try
            {
                var frontEndUser = ExecuteQuery<FrontEndUser>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault(); ;
                return frontEndUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateFrontEndUser(string query, object param)
        {
            try
            {
                var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult DeleteFrontEndUsersByIds(string query, object param)
        {
            try
            {
                var result = ExecuteQuery<BaseResult>(query, SqlCommandType.StoredProcedure, param).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
