using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;  // NewBook ve Book modelleri için gerekli namespace

namespace LibraryManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Quote> quotes = Quote.GetQuotes().OrderByDescending(x => x.Id).ToList();
            return View(quotes);
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
