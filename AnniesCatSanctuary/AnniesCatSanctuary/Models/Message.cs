namespace AnniesCatSancuary.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public int UserID { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime Timestamp { get; set; }
    }
}