namespace BloodBank.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        public string Content { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime UpDate { get; set; }

        public int UserId { get; set; }
    }
}
