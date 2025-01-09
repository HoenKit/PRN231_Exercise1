using System.ComponentModel.DataAnnotations;

namespace DemoAPICodeFirst.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; }
        public Role Role { get; set; }
    }
}
