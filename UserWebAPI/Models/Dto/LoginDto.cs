using System.ComponentModel.DataAnnotations.Schema;

namespace UserWebAPI.Models.Dto
{
    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
