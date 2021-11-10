using System.Collections.Generic;

namespace Dream14.ViewModels.Global
{

    public class EventDetail
    {
        public List<List<T1>> T1 { get; set; }
        public List<T2> T2 { get; set; }
        public List<T3> T3 { get; set; }
        public List<T4> T4 { get; set; }

        public string EventName { get; set; }
        public string EventDate { get; set; }
        public string EventTime { get; set; }

        public EventDetailStatus EventDetailStatus { get; set; }

        public List<MinMax> MinMaxList { get; set; }

        public T1PercentageDetail T1PercentageDetail { get; set; }

        public T1BetValueDetail T1BetValueDetail { get; set; }

    }

    public class T1PercentageDetail
    {
        public string Sid { get; set; }
        public string GameId { get; set; }
        public string EventDetailName { get; set; }
        public string Percentage { get; set; }
        public string TeamAL1Value { get; set; }
        public string TeamBL1Value { get; set; }
        public string TeamAB1Value { get; set; }
        public string TeamBB1Value { get; set; }
    }

    public class T1BetValueDetail
    {
        public string Sid { get; set; }
        public string GameId { get; set; }
        public string EventDetailName { get; set; }
        public float Team1BetValue { get; set; } = 0;
        public float Team2BetValue { get; set; } = 0;
    }

    public class MinMax
    {
        public string Sid { get; set; }

        public string EventDetailName { get; set; }

        public string MinValue { get; set; }

        public string MaxValue { get; set; }

        public string GameId { get; set; }
    }

    public class T2
    {
        public List<Bm1> Bm1 { get; set; }
        public List<object> Bm2 { get; set; }
    }

    public class T1
    {
        public string Mid { get; set; }
        public string Mstatus { get; set; }
        public string Mname { get; set; }
        public string Iplay { get; set; }
        public string Sid { get; set; }
        public string Nat { get; set; }
        public string B1 { get; set; }
        public string Bs1 { get; set; }
        public string B2 { get; set; }
        public string Bs2 { get; set; }
        public string B3 { get; set; }
        public string Bs3 { get; set; }
        public string L1 { get; set; }
        public string Ls1 { get; set; }
        public string L2 { get; set; }
        public string Ls2 { get; set; }
        public string L3 { get; set; }
        public string Ls3 { get; set; }
        public string Status { get; set; }
        public string Srno { get; set; }
        public string Gtype { get; set; }
        public string Utime { get; set; }
    }

    public class Bm1
    {
        public string Mid { get; set; }
        public string Mname { get; set; }
        public string Remark { get; set; }
        public string Remark1 { get; set; }
        public string Min { get; set; }
        public string Max { get; set; }
        public string Sid { get; set; }
        public string Nat { get; set; }
        public string B1 { get; set; }
        public string Bs1 { get; set; }
        public string L1 { get; set; }
        public string Ls1 { get; set; }
        public string S { get; set; }
        public string Sr { get; set; }
        public string Gtype { get; set; }
        public string Utime { get; set; }
        public string B2 { get; set; }
        public string Bs2 { get; set; }
        public string B3 { get; set; }
        public string Bs3 { get; set; }
        public string L2 { get; set; }
        public string Ls2 { get; set; }
        public string L3 { get; set; }
        public string Ls3 { get; set; }
        public string B1s { get; set; }
        public string B2s { get; set; }
        public string B3s { get; set; }
        public string L1s { get; set; }
        public string L2s { get; set; }
        public string L3s { get; set; }
    }

    public class T3
    {
        public string Mid { get; set; }
        public string Sid { get; set; }
        public string Nat { get; set; }
        public string B1 { get; set; }
        public string Bs1 { get; set; }
        public string L1 { get; set; }
        public string Ls1 { get; set; }
        public string B2 { get; set; }
        public string Bs2 { get; set; }
        public string L2 { get; set; }
        public string Ls2 { get; set; }
        public string B3 { get; set; }
        public string Bs3 { get; set; }
        public string L3 { get; set; }
        public string Ls3 { get; set; }
        public string Gtype { get; set; }
        public string Utime { get; set; }
        public string Gvalid { get; set; }
        public string Gstatus { get; set; }
        public string Remark { get; set; }
        public string Min { get; set; }
        public string Max { get; set; }
        public string Srno { get; set; }
        public string S1 { get; set; }
        public string S2 { get; set; }
        public string Ballsess { get; set; }
    }

    public class T4
    {
        public string Mid { get; set; }
        public string Sid { get; set; }
        public string Nat { get; set; }
        public string B1 { get; set; }
        public string Bs1 { get; set; }
        public string L1 { get; set; }
        public string Ls1 { get; set; }
        public string Gtype { get; set; }
        public string Utime { get; set; }
        public string Gvalid { get; set; }
        public string Gstatus { get; set; }
        public string Remark { get; set; }
        public string Min { get; set; }
        public string Max { get; set; }
        public string Srno { get; set; }
    }


}
