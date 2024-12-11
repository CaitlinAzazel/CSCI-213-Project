/* HomeController.cs */
using Microsoft.AspNetCore.Mvc;

namespace AnniesCatSancuary.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DogListings()
        {
            // Sample data (this would typically come from a database)
            var dogs = new List<Dog>
            {
                new Dog { Name = "Navi", Breed = "Husky", Age = 2, Description = "Friendly, active, female" },
                new Dog { Name = "Briggin", Breed = "Viszla", Age = 9, Description = "Curious and energetic male" },
                new Dog { Name = "Ruso", Breed = "Golden Retriever", Age = 1, Description = "Energetic, exciteable, male, good with kids"}
            };

            return View(dogs);
        }
    }
    public class Dog
    {
        public string Name { get; set; } = string.Empty;
        public string Breed { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Description { get; set; } = string.Empty;
    }

}