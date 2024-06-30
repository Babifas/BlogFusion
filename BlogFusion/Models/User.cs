using System.ComponentModel.DataAnnotations;

namespace BlogFusion.Models
{
    public class User
    {
        [Key]
        public int  UserId { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
