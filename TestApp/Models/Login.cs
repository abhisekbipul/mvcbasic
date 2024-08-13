using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class Login
    {
        [Required(ErrorMessage ="*")]
        [Display]
        public string Username {  get; set; }

        [Required(ErrorMessage ="*")]
        [Display]
        public string Password { get; set; }
    }
}
