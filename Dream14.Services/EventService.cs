using Dream14.Core.DomainServices;
using Dream14.Core.Helper;
using Dream14.Core.Repositories;
using Dream14.ViewModels.Global;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Dream14.Services
{
    public class EventService : IEventService
    {
        public const string ApiUrl = "http://marketsarket.in:3000/";

        /// <summary>
        /// Private IUnitOfWork Data Member
        /// </summary>
        //private IUnitOfWork _unitOfWork;
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// EventService Constructor
        /// </summary>
        /// <param name="unitOfWork">IUnitOfWork object reference</param>
        public EventService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddOrUpdateEvents()
        {
            List<Cricket> crickets = GetCricketList();
            bool result = _unitOfWork.EventRepo.UpdateAllEvents("usp_UpdateAllEvents");
            if (result)
            {
                crickets.ForEach(cricket =>
                {
                    _unitOfWork.EventRepo.AddOrUpdateEvent("usp_AddOrUpdateEvent", new { gameId = cricket.GameId });
                });
            }
        }


        public CricketList GetEventList(string roleName, string userType)
        {
            CricketList cricketList = null;

            List<Cricket> crickets = GetCricketList();
            List<string> gameIdList = GetSelectedGameIds();
            AddEventDetail(crickets);

            if (roleName == "SuperAdmin")
            {
                cricketList = new CricketList
                {
                    Crickets = crickets,
                    GameIds = gameIdList,
                };
            }
            else if (roleName == "Admin" || roleName == "Master" || roleName == "Agent")
            {
                if (userType == "Vip")
                {
                    Cricket cricket;
                    List<Cricket> filteredCricketList = new List<Cricket>();
                    gameIdList.ForEach(gameId =>
                    {
                        cricket = crickets.Where(x => x.GameId == gameId).FirstOrDefault();
                        if (cricket != null)
                            filteredCricketList.Add(cricket);
                    });

                    cricketList = new CricketList
                    {
                        Crickets = filteredCricketList,
                        GameIds = gameIdList,
                    };
                }
                else
                {
                    cricketList = new CricketList
                    {
                        Crickets = crickets,
                        GameIds = gameIdList,
                    };
                }
            }

            return cricketList;
        }

        public void AddOrUpdateEventDetail(string gameId)
        {
            List<DetailStatus> detailStatusList = new List<DetailStatus>
            {
                new DetailStatus { EventDetailName="T1",IsActive=true},
                new DetailStatus { EventDetailName = "T2", IsActive = true },
                new DetailStatus { EventDetailName = "T3", IsActive = true },
                new DetailStatus { EventDetailName = "T4", IsActive = true },
            };


            detailStatusList.ForEach(detailStatus =>
            {
                _unitOfWork.EventRepo.AddOrUpdateEventDetail("usp_AddOrUpdateEventDetail", new { gameId, detailStatus.EventDetailName, detailStatus.IsActive });
            });

            EventDetail eventDetail = GetCricketDetail(gameId);
            if (eventDetail.T3 != null && eventDetail.T3.Count > 0)
            {
                eventDetail.T3.ForEach(t3 =>
                {
                    _unitOfWork.EventRepo.AddOrUpdateT3SubEventDetail("usp_AddOrUpdateT3SubEventDetail", new { gameId, SubEventId = t3.Sid, isActive = true });
                });
            }
            if (eventDetail.T4 != null && eventDetail.T4.Count > 0)
            {
                eventDetail.T4.ForEach(t4 =>
                {
                    _unitOfWork.EventRepo.AddOrUpdateT4SubEventDetail("usp_AddOrUpdateT4SubEventDetail", new { gameId, SubEventId = t4.Sid, isActive = true });
                });
            }
        }


        public EventDetail GetEventDetail(string roleName, string userType, string gameId)
        {
            EventDetail eventDetail = GetCricketDetail(gameId);
            eventDetail.EventDetailStatus = GetEventDetailStatusList(gameId);
            AddEventDetail(eventDetail, gameId);


            EventDetail filteredEventDetail = new EventDetail();
            if (roleName == "SuperAdmin")
            {
                filteredEventDetail = eventDetail;
            }
            else if (roleName == "Admin" || roleName == "Master" || roleName == "Agent")
            {
                if (userType == "Vip")
                {
                    filteredEventDetail = FilterEventDetail(eventDetail, gameId);
                }
                else
                {
                    filteredEventDetail = eventDetail;
                }
            }
            return filteredEventDetail;
        }



        public BaseResult ChangeEventsStatus(List<Cricket> cricketList)
        {
            BaseResult baseResult = null;

            cricketList.ForEach(cricket =>
            {
                baseResult = _unitOfWork.EventRepo.ChangeEventStatus("usp_ChangeEventStatus", new { gameId = cricket.GameId, isSelected = cricket.M1.ToLower() == "false" ? false : true });
            });

            return baseResult;
        }

        public BaseResult ChangeEventDetailStatus(string eventDetailName, string gameId, string isSelected)
        {
            return _unitOfWork.EventRepo.ChangeEventDetailStatus("usp_ChangeEventDetailStatus", new { eventDetailName, gameId, isSelected = isSelected.ToLower() == "false" ? false : true });
        }

        public List<T3> GetT3CheckBoxDetails(string gameId)
        {
            return _unitOfWork.EventRepo.GetT3CheckBoxDetails("usp_GetT3CheckBoxDetails", new { gameId });
        }

        public List<T4> GetT4CheckBoxDetails(string gameId)
        {
            return _unitOfWork.EventRepo.GetT4CheckBoxDetails("usp_GetT4CheckBoxDetails", new { gameId });
        }

        public BaseResult UpdateT3Status(List<T3> t3List)
        {
            BaseResult baseResult = null;
            t3List.ForEach(t3 =>
            {
                baseResult = _unitOfWork.EventRepo.UpdateT3Status("usp_UpdateT3Status", new { gameId = t3.Mid, sid = t3.Sid, isSelected = t3.Nat.ToLower() == "false" ? false : true });
            });

            return baseResult;
        }

        public BaseResult UpdateT4Status(List<T4> t4List)
        {
            BaseResult baseResult = null;
            t4List.ForEach(t4 =>
            {
                baseResult = _unitOfWork.EventRepo.UpdateT4Status("usp_UpdateT4Status", new { gameId = t4.Mid, sid = t4.Sid, isSelected = t4.Nat.ToLower() == "false" ? false : true });
            });

            return baseResult;
        }


        private List<Cricket> GetCricketList()
        {
            List<Cricket> cricketList = new List<Cricket>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                string response = client.GetStringAsync("getcricketmatches").Result;
                if (response != null)
                {
                    cricketList = JsonConvert.DeserializeObject<List<Cricket>>(response);
                    cricketList = cricketList.Where(x => x.Vir == 1).ToList();
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }

            return cricketList;
        }

        private EventDetail GetCricketDetail(string gameId)
        {
            EventDetail eventDetail = new EventDetail();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                string response = client.GetStringAsync("getcricketdemo11/" + gameId).Result;
                if (response != null)
                {
                    eventDetail = JsonConvert.DeserializeObject<EventDetail>(response);
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }

                return eventDetail;
            }
        }

        private void AddEventDetail(List<Cricket> cricketList)
        {
            cricketList.ForEach(cricket =>
            {
                cricket.EventDetail = GetCricketDetail(cricket.GameId);
            });
        }

        private void AddEventDetail(EventDetail eventDetail, string gameId)
        {
            List<Cricket> crickets = GetCricketList();
            if (crickets.Count > 0)
            {
                Cricket cricket = crickets.Where(x => x.GameId == gameId).FirstOrDefault();
                if (cricket != null)
                {
                    string eventName = cricket.EventName;
                    eventDetail.EventName = eventName.Substring(0, eventName.IndexOf("/"));
                    string[] arr = eventName.Substring(eventName.IndexOf("/") + 1).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    eventDetail.EventDate = arr[1] + " " + arr[0] + " " + arr[2];
                    eventDetail.EventTime = arr[3];
                }
            }
        }

        private List<string> GetSelectedGameIds()
        {
            return _unitOfWork.EventRepo.GetSelectedGameIds("usp_GetSelectedGameIds");
        }

        private EventDetailStatus GetEventDetailStatusList(string gameId)
        {
            return _unitOfWork.EventRepo.GetEventDetailStatusList("usp_GetEventDetailStatusList", new { gameId });
        }

        private EventDetail FilterEventDetail(EventDetail eventDetail, string gameId)
        {
            EventDetail filteredEventDetail = new EventDetail();

            bool t1Status = _unitOfWork.EventRepo.GetT1Status("usp_GetT1Status", new { gameId });
            if (t1Status)
                filteredEventDetail.T1 = eventDetail.T1;

            bool t2Status = _unitOfWork.EventRepo.GetT2Status("usp_GetT2Status", new { gameId });
            if (t2Status)
                filteredEventDetail.T2 = eventDetail.T2;

            bool t3Status = _unitOfWork.EventRepo.GetT3Status("usp_GetT3Status", new { gameId });
            if (t3Status)
                filteredEventDetail.T3 = eventDetail.T3;

            bool t4Status = _unitOfWork.EventRepo.GetT3Status("usp_GetT4Status", new { gameId });
            if (t3Status)
                filteredEventDetail.T3 = eventDetail.T3;

            List<T3> t3List = GetT3CheckBoxDetails(gameId);

            List<T4> t4List = GetT4CheckBoxDetails(gameId);

           
            if (t3List.Count > 0)
            {
                filteredEventDetail.T3 = new List<T3>();
                eventDetail.T3.ForEach(t3 =>
                {
                    T3 t3ListItem = t3List.Where(x => x.Sid == t3.Sid).FirstOrDefault();
                    if (t3ListItem != null && t3ListItem.Mid.ToLower() == "true")
                    {
                        filteredEventDetail.T3.Add(t3);
                    }
                });
            }
            else
            {
                filteredEventDetail.T3 = eventDetail.T3;
            }

            if (t4List.Count > 0)
            {
                filteredEventDetail.T4 = new List<T4>();
                eventDetail.T4.ForEach(t4 =>
                {
                    T4 t4ListItem = t4List.Where(x => x.Sid == t4.Sid).FirstOrDefault();
                    if (t4ListItem != null && t4ListItem.Mid.ToLower() == "true")
                    {
                        filteredEventDetail.T4.Add(t4);
                    }
                });
            }
            else
            {
                filteredEventDetail.T4 = eventDetail.T4;
            }

            AddEventDetail(filteredEventDetail, gameId);
            filteredEventDetail.EventDetailStatus = eventDetail.EventDetailStatus;

            return filteredEventDetail;
        }
    }
}
