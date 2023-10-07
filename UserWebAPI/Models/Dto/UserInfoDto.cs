using System.ComponentModel.DataAnnotations;

namespace UserWebAPI.Models.Dto
{
    public class UserInfoDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int Role { get; set; }
    }
}
