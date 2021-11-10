using Dapper;
using Dream14.Core.Repositories;
using Dream14.ViewModels.FrontEnd;
using Dream14.ViewModels.Global;
using System;
using System.Collections.Generic;
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
                return Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                return Connection.Query<BaseResult>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, string> GetUserBetButtonValue(string query, object param)
        {
            try
            {
                BetButtonStatus betButtonStatus = Connection.Query<BetButtonStatus>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return BetButtonStatus2Dictionary(betButtonStatus);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateUserBetValue(string query, object param)
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

        public string GetUserStakeValue(string query, object param)
        {
            try
            {
                return Connection.Query<string>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BaseResult UpdateBetButtonValue(string query, object param)
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

        private Dictionary<string, string> BetButtonStatus2Dictionary(BetButtonStatus betButtonStatus)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            if (betButtonStatus != null)
            {
                keyValuePairs.Add("Button1", string.Concat(betButtonStatus.Btn1Name, ":", betButtonStatus.Btn1Value));
                keyValuePairs.Add("Button2", string.Concat(betButtonStatus.Btn2Name, ":", betButtonStatus.Btn2Value));
                keyValuePairs.Add("Button3", string.Concat(betButtonStatus.Btn3Name, ":", betButtonStatus.Btn3Value));
                keyValuePairs.Add("Button4", string.Concat(betButtonStatus.Btn4Name, ":", betButtonStatus.Btn4Value));
                keyValuePairs.Add("Button5", string.Concat(betButtonStatus.Btn5Name, ":", betButtonStatus.Btn5Value));
                keyValuePairs.Add("Button6", string.Concat(betButtonStatus.Btn6Name, ":", betButtonStatus.Btn6Value));
                keyValuePairs.Add("Button7", string.Concat(betButtonStatus.Btn7Name, ":", betButtonStatus.Btn7Value));
                keyValuePairs.Add("Button8", string.Concat(betButtonStatus.Btn8Name, ":", betButtonStatus.Btn8Value));
                keyValuePairs.Add("Button9", string.Concat(betButtonStatus.Btn9Name, ":", betButtonStatus.Btn9Value));
                keyValuePairs.Add("Button10", string.Concat(betButtonStatus.Btn10Name, ":", betButtonStatus.Btn10Value));
            }
            else
            {
                keyValuePairs.Add("Button1", string.Concat("1000", ":", "1000"));
                keyValuePairs.Add("Button2", string.Concat("5000", ":", "5000"));
                keyValuePairs.Add("Button3", string.Concat("10000", ":", "10000"));
                keyValuePairs.Add("Button4", string.Concat("25000", ":", "25000"));
                keyValuePairs.Add("Button5", string.Concat("50000", ":", "50000"));
                keyValuePairs.Add("Button6", string.Concat("100000", ":", "100000"));
                keyValuePairs.Add("Button7", string.Concat("200000", ":", "200000"));
                keyValuePairs.Add("Button8", string.Concat("500000", ":", "500000"));
                keyValuePairs.Add("Button9", string.Concat("1000000", ":", "1000000"));
                keyValuePairs.Add("Button10", string.Concat("2500000", ":", "2500000"));
            }

            return keyValuePairs;
        }
    }
}
