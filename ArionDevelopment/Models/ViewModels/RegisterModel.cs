using System.ComponentModel.DataAnnotations;


namespace ArionDevelopment.Models.ViewModels
{
    public class RegisterModel
    {



        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public string Zip { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords must match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }



        public string ReturnUrl { get; set; } = "/";
    }
}