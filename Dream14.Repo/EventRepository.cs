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


        public bool UpdateAllEvents(string query)
        {
            try
            {
                return Connection.Query<bool>(query, null, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddOrUpdateEvent(string query, object param)
        {
            try
            {
                Connection.Query(query, param, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetSelectedGameIds(string query)
        {
            try
            {
                return Connection.Query<string>(query, null, commandType: CommandType.StoredProcedure).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddOrUpdateEventDetail(string query, object param)
        {
            try
            {
                Connection.Query(query, param, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddOrUpdateT3SubEventDetail(string query, object param)
        {
            try
            {
                Connection.Query(query, param, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddOrUpdateT4SubEventDetail(string query, object param)
        {
            try
            {
                Connection.Query(query, param, commandType: CommandType.StoredProcedure);
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
                return Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult ChangeEventDetailStatus(string query, object param)
        {
            try
            {
                return Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EventDetailStatus GetEventDetailStatusList(string query, object param)
        {
            try
            {
                EventDetailStatus eventDetailStatus = new EventDetailStatus
                {
                    DetailStatusList = Connection.Query<DetailStatus>(query, param, commandType: CommandType.StoredProcedure).ToList()
                };
                return eventDetailStatus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MinMax> GetMinMaxValue(string query, object param)
        {
            try
            {
                return Connection.Query<MinMax>(query, param, commandType: CommandType.StoredProcedure).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<T3> GetT3CheckBoxDetails(string query, object param)
        {
            try
            {
                return Connection.Query<T3>(query, param, commandType: CommandType.StoredProcedure).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<T4> GetT4CheckBoxDetails(string query, object param)
        {
            try
            {
                return Connection.Query<T4>(query, param, commandType: CommandType.StoredProcedure).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateT3Status(string query, object param)
        {
            try
            {
                return Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateT4Status(string query, object param)
        {
            try
            {
                return Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateMatchOddsMinMax(string query, object param)
        {
            try
            {
                return Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateBookmakerMarketMinMax(string query, object param)
        {
            try
            {
                return Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateSessionMarketMinMax(string query, object param)
        {
            try
            {
                return Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateFancy1MarketMinMax(string query, object param)
        {
            try
            {
                return Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GetT1Status(string query, object param)
        {
            try
            {
                return Connection.Query<bool>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GetT2Status(string query, object param)
        {
            try
            {
                return Connection.Query<bool>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GetT3Status(string query, object param)
        {
            try
            {
                return Connection.Query<bool>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GetT4Status(string query, object param)
        {
            try
            {
                return Connection.Query<bool>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public BaseResult RemoveBookmakerMarketMinMax(string query, object param)
        {
            try
            {
                return Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult RemoveSessionMarketMinMax(string query, object param)
        {
            try
            {
                return Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BaseResult RemoveFancy1MarketMinMax(string query, object param)
        {
            try
            {
                return Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
