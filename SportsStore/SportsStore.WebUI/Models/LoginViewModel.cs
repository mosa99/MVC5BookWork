using System.ComponentModel.DataAnnotations;

namespace SportsStore.WebUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter your Username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter your Password")]
        public string Password { get; set; }
    }
}