using IS6225_ModelBinding.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IS6225_ModelBinding.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult SignIn()
        {            
            return View();
        }

        public IActionResult SignUp()
        {
            Register member = new Register();
            return View(member);
        }
        [HttpPost]
        public IActionResult SignUp(Register member)
        {
            return View(member);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}