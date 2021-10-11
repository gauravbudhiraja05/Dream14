using Dream14.ViewModels.Global;
using System.Collections.Generic;

namespace Dream14.Core.DomainServices
{
    public interface IEventService
    {
        CricketList GetEventList(string roleName, string userType);

        EventDetail GetEventDetail(string roleName, string gameId);

        BaseResult ChangeEventsStatus(List<Cricket> cricketList);
    }
}
