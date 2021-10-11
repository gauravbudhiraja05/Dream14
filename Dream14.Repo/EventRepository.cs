using Dapper;
using Dream14.Core.Repositories;
using Dream14.ViewModels.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Dream14.Repo
{
    public class EventRepository : Repository, IEventRepository
    {

        #region Constructor

        /// <summary>
        /// EventRepository Constructor
        /// </summary>
        /// <param name="context">Database Context</param>
        public EventRepository(IDbConnection connection) : base(connection)
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

        public List<string> GetSelectedGameIds(string query)
        {
            try
            {
                var result = Connection.Query<string>(query, null, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult ChangeEventStatus(string query, object param)
        {
            try
            {
                var result = Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
