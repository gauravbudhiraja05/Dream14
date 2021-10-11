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

            if (roleName == "Admin" || roleName == "Master" || roleName == "Agent")
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


        public EventDetail GetEventDetail(string roleName, string gameId)
        {
            EventDetail eventDetail = GetCricketDetail(gameId);
            AddEventDetail(eventDetail, gameId);
            EventDetail filteredEventDetail = new EventDetail();

            if (roleName == "SuperAdmin")
            {
                filteredEventDetail = eventDetail;
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
    }
}
