using System.ComponentModel.DataAnnotations;

namespace Requestrr.WebApi.Controllers
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
