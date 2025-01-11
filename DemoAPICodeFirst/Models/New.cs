namespace DemoAPICodeFirst.Models
{
    public class New
    {
        public int NewId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; }
        public User? User { get; set; }
        public int UserId { get; set; }
    }
}
