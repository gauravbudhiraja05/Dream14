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

        List<T3> GetT3CheckBoxDetails(string query, object param);

        List<T4> GetT4CheckBoxDetails(string query, object param);

        BaseResult UpdateT3Status(string query, object param);

        BaseResult UpdateT4Status(string query, object param);
    }
}
