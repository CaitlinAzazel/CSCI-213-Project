// Models/Message.cs
namespace AnniesCatSanctuary.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime DateSent { get; set; } = DateTime.Now;
    }
}
