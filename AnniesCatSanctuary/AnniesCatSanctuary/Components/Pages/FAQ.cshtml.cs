using Microsoft.AspNetCore.Mvc.RazorPages;
using AnniesCatSanctuary.Models;

namespace AnniesCatSanctuary.Pages
{
    public class FAQModel : PageModel
    {
        public List<FAQ> FAQs { get; set; }

        public void OnGet()
        {
            // Mock FAQ list - replace with a database call if needed
            FAQs = new List<FAQ>
            {
                new FAQ { Id = 1, Question = "How do I adopt a cat?", Answer = "Visit the adoption page, select a cat, and fill out the adoption application form." },
                new FAQ { Id = 2, Question = "What are the adoption fees?", Answer = "Adoption fees range from $50 to $150 depending on the cat's age and health condition." },
                new FAQ { Id = 3, Question = "Can I volunteer at the shelter?", Answer = "Yes! Visit our volunteer page to learn more and sign up." }
            };
        }
    }
}
