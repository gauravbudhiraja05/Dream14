namespace Dream14.ViewModels.SuperAdmin
{

    /// <summary>
    /// FrontEndUser data structure to create admin user
    /// </summary>
    public class FrontEndUser
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public string CreationDate { get; set; }

        public string RoleName { get; set; }

        public bool IsActive { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public int DeletedBy { get; set; }

        public string CreatedDateDisplay { get; set; }

    }
}
