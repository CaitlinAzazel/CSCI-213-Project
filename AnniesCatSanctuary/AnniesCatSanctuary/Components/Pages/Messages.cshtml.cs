using Microsoft.AspNetCore.Mvc.RazorPages;
using AnniesCatSanctuary.Models;

namespace AnniesCatSanctuary.Pages
{
    public class MessagesModel : PageModel
    {
        public List<Message> Messages { get; set; }

        public void OnGet()
        {
            // Mock messages - replace with a database call if needed
            Messages = new List<Message>
            {
                new Message { Id = 1, Sender = "John Doe", Recipient = "Jane Smith", Subject = "Adoption Inquiry", Content = "I am interested in adopting Luna.", DateSent = DateTime.Now },
                new Message { Id = 2, Sender = "Admin", Recipient = "John Doe", Subject = "Adoption Approved", Content = "Congratulations! Your adoption request has been approved.", DateSent = DateTime.Now.AddDays(-1) }
            };
        }
    }
}
