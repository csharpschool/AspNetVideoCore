using System.ComponentModel.DataAnnotations;

namespace AspNetVideoCore.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }
        [DataType(DataType.Password), Required]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
