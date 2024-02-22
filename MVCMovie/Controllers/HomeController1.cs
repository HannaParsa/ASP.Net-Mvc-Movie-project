using Microsoft.AspNetCore.Mvc;

namespace MVCMovie.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcom(string message, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + message;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
