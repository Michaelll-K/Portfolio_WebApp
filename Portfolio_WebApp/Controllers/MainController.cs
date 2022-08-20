using Microsoft.AspNetCore.Mvc;

namespace Portfolio_WebApp.Controllers
{
    public class MainController : Controller
    {
        public IActionResult MainPage()
        {
            ViewData["Title"] = "Aplication";
            return View();
        }

        public IActionResult SingUp()
        {
            ViewData["Title"] = "SingUp";
            return View();
        }
    }
}
