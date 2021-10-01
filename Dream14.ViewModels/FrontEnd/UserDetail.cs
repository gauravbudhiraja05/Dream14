using System;
using System.Collections.Generic;
using System.Text;

namespace Dream14.ViewModels.FrontEnd
{
    public class UserDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber1 { get; set; }
        public string MobileNumber2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public bool IsRead { get; set; }
    }
}
