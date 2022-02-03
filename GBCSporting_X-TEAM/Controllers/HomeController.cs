using GBCSporting_X_TEAM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GBCSporting_X_TEAM.Controllers
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

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Technicians()
        {
            return View();
        }

        public IActionResult Customers()
        {
            return View();
        }

        public IActionResult Incidents()
        {
            return View();
        }

        public IActionResult Registrations()
        {
            return View();
        }

        public IActionResult UpdateIncident()
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