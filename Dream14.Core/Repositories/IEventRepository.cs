using System.Collections.Generic;
using Dream14.ViewModels.Global;

namespace Dream14.Core.Repositories
{
    public interface IEventRepository
    {
        bool UpdateAllEvents(string query);

        void AddOrUpdateEvent(string query, object param);

        List<string> GetSelectedGameIds(string query);

        void AddOrUpdateEventDetail(string query, object param);

        void AddOrUpdateT3SubEventDetail(string query, object param);

        void AddOrUpdateT4SubEventDetail(string query, object param);

        BaseResult ChangeEventStatus(string query, object param);

        BaseResult ChangeEventDetailStatus(string query, object param);

        EventDetailStatus GetEventDetailStatusList(string query, object param);

        List<MinMax> GetMinMaxValue(string query, object param);

        List<T3> GetT3CheckBoxDetails(string query, object param);

        List<T4> GetT4CheckBoxDetails(string query, object param);

        BaseResult UpdateT3Status(string query, object param);

        BaseResult UpdateT4Status(string query, object param);

        BaseResult UpdateMatchOddsMinMax(string query, object param);

        BaseResult UpdateBookmakerMarketMinMax(string query, object param);

        BaseResult UpdateSessionMarketMinMax(string query, object param);

        BaseResult UpdateFancy1MarketMinMax(string query, object param);

        bool GetT1Status(string query, object param);

        bool GetT2Status(string query, object param);

        bool GetT3Status(string query, object param);

        bool GetT4Status(string query, object param);

        BaseResult RemoveBookmakerMarketMinMax(string query, object param);

        BaseResult RemoveSessionMarketMinMax(string query, object param);

        BaseResult RemoveFancy1MarketMinMax(string query, object param);
    }
}
