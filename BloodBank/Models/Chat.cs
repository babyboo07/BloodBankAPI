namespace BloodBank.Models
{
    public class Chat
    {
        public int ChatId { get; set; }

        public string Content { get; set; }

        public int Donnor { get; set; }

        public int BloodNeeder { get; set; }
    }
}
