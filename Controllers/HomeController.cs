using System.Diagnostics;
using EduLearn_Academy.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduLearn_Academy.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new User { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
