using Dream14.Core.DomainServices;
using Dream14.ViewModels.Global;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Dream14.Services
{
    public class ApiService : IApiService
    {
        public const string ApiUrl = "http://marketsarket.in:3000/";

        public async Task<List<Cricket>> GetApiListAsync()
        {
            List<Cricket> crickets = await GetCricketListAsync();

            foreach (Cricket cricket in crickets)
            {
                cricket.EventDetail = await GetCricketDetailAsync(cricket.GameId);
            }

            return crickets;
        }

        public async Task<EventDetail> GetEventDetailAsync(string gameId)
        {
            EventDetail eventDetail = await GetCricketDetailAsync(gameId);
            List<Cricket> crickets = await GetCricketListAsync();
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

            return eventDetail;
        }


        private async Task<List<Cricket>> GetCricketListAsync()
        {
            List<Cricket> crickets = new List<Cricket>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await client.GetAsync("getcricketmatches");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    crickets = JsonConvert.DeserializeObject<List<Cricket>>(json);
                    crickets = crickets.Where(x => x.Vir == 1).ToList();
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }

            return crickets;
        }

        private async Task<EventDetail> GetCricketDetailAsync(string gameId)
        {
            EventDetail eventDetail = new EventDetail();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await client.GetAsync("getcricketdemo11/" + gameId);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    eventDetail = JsonConvert.DeserializeObject<EventDetail>(json);
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }

                return eventDetail;
            }
        }
    }
}
