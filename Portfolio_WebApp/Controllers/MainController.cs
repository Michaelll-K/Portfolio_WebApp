using Microsoft.AspNetCore.Mvc;

namespace Portfolio_WebApp.Controllers
{
    public class MainController : Controller
    {
        public IActionResult MainPage()
        {
            return View();
        }
    }
}
