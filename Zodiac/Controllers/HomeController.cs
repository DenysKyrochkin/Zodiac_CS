using Zodiac.Models;
using Microsoft.AspNetCore.Mvc;

namespace Zodiac.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result()
        {
            Dates dates = new Dates(
                HttpContext.Request.Form["Date"]);
            return View(dates);
        }

   
    }
}
