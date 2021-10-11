using System.Collections.Generic;

namespace Dream14.ViewModels.Global
{
    public class Cricket
    {
        public string GameId { get; set; }
        public string MarketId { get; set; }
        public string Eid { get; set; }
        public string EventName { get; set; }
        public string InPlay { get; set; }
        public string Tv { get; set; }
        public double Back1 { get; set; }
        public double Lay1 { get; set; }
        public double Back11 { get; set; }
        public double Lay11 { get; set; }
        public double Back12 { get; set; }
        public double Lay12 { get; set; }
        public string M1 { get; set; }
        public string F { get; set; }
        public int Vir { get; set; }

        public EventDetail EventDetail;
        
    }

    public class CricketList
    {
        public List<Cricket> Crickets { get; set; }

        public List<string> GameIds { get; set; }
    }
}
