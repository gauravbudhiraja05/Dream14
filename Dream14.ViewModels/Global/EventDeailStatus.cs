using System;
using System.Collections.Generic;
using System.Text;

namespace Dream14.ViewModels.Global
{
    public class EventDetailStatus
    {
        public List<DetailStatus> DetailStatusList { get; set; }
    }

    public class DetailStatus
    {

        public string EventDetailName { get; set; }
        
        public bool IsActive { get; set; }
    }
}
