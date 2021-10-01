namespace Dream14.ViewModels.SuperAdmin
{

    /// <summary>
    /// AgentUser data structure to create admin user
    /// </summary>
    public class AgentUser
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string MobileNumber { get; set; }

        public string CreationDate { get; set; }

        public string RoleName { get; set; }

        public bool IsActive { get; set; }

        public bool IsBetLock { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public int DeletedBy { get; set; }

        public float Balance { get; set; }

        public float Deposit { get; set; }

        public float WithDrawl { get; set; }

        public float Limit { get; set; }

        public float ProfitLoss { get; set; }

    }
}
