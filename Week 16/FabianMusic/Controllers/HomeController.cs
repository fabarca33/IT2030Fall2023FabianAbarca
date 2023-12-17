using FabianMusic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FabianMusic.Controllers
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

        public IActionResult About()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }

        public IActionResult SetSessionVariables()
            {
                /*string fabian = HttpContext.Session.GetString("FirstName");
                string abarca = HttpContext.Session.GetString("LastName");
                string IT2030 = HttpContext.Session.GetString("Course");
                int num = HttpContext.Session.GetInt32("FavNum");*/

                HttpContext.Session.SetString("FirstName", "Fabian");
                HttpContext.Session.SetString("LastName", "Abarca");
                HttpContext.Session.SetString("Course", "IT2030");
                HttpContext.Session.SetInt32("FavNum", 33);


                return View();
            }

        public IActionResult ClearSessionVariables()
            {
                HttpContext.Session.Remove("FirstName");
                HttpContext.Session.Remove("LastName");
                HttpContext.Session.Remove("Course");
                HttpContext.Session.Remove("FavNum");

                return View();

            }
        public IActionResult Tools()
        {
            return View();
        }

        public IActionResult Events()
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