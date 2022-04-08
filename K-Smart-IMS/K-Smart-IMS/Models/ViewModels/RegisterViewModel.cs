using System.ComponentModel.DataAnnotations;

namespace K_Smart_IMS.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter a valid username.")]
        [StringLength(255)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a valid password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your passwords.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}