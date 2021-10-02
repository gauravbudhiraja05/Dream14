using Dapper;
using Dream14.Core.Repositories;
using Dream14.ViewModels.Global;
using System;
using System.Data;
using System.Linq;

namespace Dream14.Repo
{
    public class FrontEndRepository : Repository, IFrontEndRepository
    {
        #region Constructor

        /// <summary>
        /// FrontEndRepository Constructor
        /// </summary>
        /// <param name="context">Database Context</param>
        public FrontEndRepository(IDbConnection connection) : base(connection)
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

        public BaseResult CheckOldPassword(string query, object param)
        {
            try
            {
                BaseResult result = Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult ChangePassword(string query, object param)
        {
            try
            {
                BaseResult result = Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
