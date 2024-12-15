using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AnniesCatSanctuary.Models;

namespace AnniesCatSanctuary.Pages
{
    public class ManageFAQsModel : PageModel
    {
        [BindProperty]
        public FAQ NewFAQ { get; set; }
        public List<FAQ> FAQs { get; set; }

        public void OnGet()
        {
            // Mock FAQ list - replace with a database call if needed
            FAQs = new List<FAQ>
            {
                new FAQ { Id = 1, Question = "How do I adopt a cat?", Answer = "Visit the adoption page, select a cat, and fill out the adoption application form." },
                new FAQ { Id = 2, Question = "What are the adoption fees?", Answer = "Adoption fees range from $50 to $150 depending on the cat's age and health condition." }
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Save the new FAQ - replace with database logic if needed
            TempData["SuccessMessage"] = "FAQ added successfully!";
            return RedirectToPage("FAQ");
        }
    }
}
