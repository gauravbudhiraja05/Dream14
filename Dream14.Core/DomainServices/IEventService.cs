using Dream14.ViewModels.Global;
using System.Collections.Generic;

namespace Dream14.Core.DomainServices
{
    public interface IEventService
    {
        void AddOrUpdateEvents();

        CricketList GetEventList(string roleName, string userType);

        void AddOrUpdateEventDetail(string gameId);

        EventDetail GetEventDetail(string roleName, string userType, string gameId);

        BaseResult ChangeEventsStatus(List<Cricket> cricketList);

        BaseResult ChangeEventDetailStatus(string eventDetailName, string gameId, string isSelected);

        List<T3> GetT3CheckBoxDetails(string gameId);

        List<T4> GetT4CheckBoxDetails(string gameId);

        BaseResult UpdateT3Status(List<T3> t3List);

        BaseResult UpdateT4Status(List<T4> t4List);

        BaseResult UpdateMatchOddsMinMax(string maxValue, string minValue, string gameId);

        BaseResult UpdateBookmakerMarketMinMax(string maxValue, string minValue, string gameId);

        BaseResult UpdateSessionMarketMinMax(string maxValue, string minValue, string gameId, string sid);

        BaseResult UpdateFancy1MarketMinMax(string maxValue, string minValue, string gameId, string sid);

        BaseResult RemoveBookmakerMarketMinMax(string gameId);

        BaseResult RemoveSessionMarketMinMax(string gameId, string sid);

        BaseResult RemoveFancy1MarketMinMax(string gameId, string sid);

        BaseResult UpdateT1Percentage(T1PercentageDetail t1PercentageDetail);

        BaseResult RemoveT1Percentage(string gameId);
    }
}
