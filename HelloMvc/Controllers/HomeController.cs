using System.Diagnostics;
using HelloMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMvc.Controllers
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
            var person = new Person
            {
                PersonID = 1,
                FirstName = "Elvis",
                MiddleName = "Aaron", // his actual real name. fun fact. 
                LastName = "Presley"
            };

            return View(person);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
