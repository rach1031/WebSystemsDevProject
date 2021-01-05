using System.ComponentModel.DataAnnotations;


namespace ArionDevelopment.Models.ViewModels
{
    public class LoginModel
    {



        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }

       



        public string ReturnUrl { get; set; } = "/";
    }
}