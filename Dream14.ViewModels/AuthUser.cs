using System.ComponentModel.DataAnnotations;

namespace Dream14.ViewModels
{
    /// <summary>
    /// User Authentication Params  data structure
    /// </summary>
    public class AuthUser
    {
        [Required(ErrorMessage = "Please enter the username")]
        //[EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string UserName { get; set; }

        public string WindowsUserId { get; set; }

        //[Required(ErrorMessage ="Please enter the password")]
        public string Password { get; set; }
    }
}
