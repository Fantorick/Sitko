using Microsoft.AspNetCore.Mvc;
using Sitko.Models;
using Sitko.Services;
using System.Diagnostics;

namespace Sitko.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ContentService _contentService;

        public HomeController(ILogger<HomeController> logger, ContentService contentService)
        {
            _logger = logger;
            _contentService = contentService;
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
