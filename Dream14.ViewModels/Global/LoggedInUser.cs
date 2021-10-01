using System;

namespace Dream14.ViewModels.Global
{
    /// <summary>
    /// Logged-In User Information Data Structure
    /// </summary>
    public class LoggedInUser : BaseResult
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string RoleName { get; set; }
        public string Balance { get; set; }
    }
}
