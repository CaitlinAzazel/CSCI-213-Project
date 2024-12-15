using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AnniesCatSanctuary.Models;

namespace AnniesCatSanctuary.Pages
{
    public class SendMessageModel : PageModel
    {
        [BindProperty]
        public Message NewMessage { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Save the message - replace with a database call if needed
            TempData["SuccessMessage"] = "Message sent successfully!";
            return RedirectToPage("Messages");
        }
    }
}
