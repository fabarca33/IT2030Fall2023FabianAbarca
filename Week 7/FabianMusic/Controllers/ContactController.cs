using Microsoft.AspNetCore.Mvc;
using FabianMusic.Models;

namespace FabianMusic.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
            //ViewBag.FV = model.ContactModel();
            return View(model);
        }
    }
}
