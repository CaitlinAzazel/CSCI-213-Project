namespace AnniesCatSanctuary.Controllers
{
    public class FAQController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FAQController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var faqs = _context.FAQs.ToList();
            return View(faqs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FAQ faq)
        {
            if (ModelState.IsValid)
            {
                _context.FAQs.Add(faq);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(faq);
        }
    }
}