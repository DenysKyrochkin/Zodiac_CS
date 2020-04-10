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
            if(dates.Age > 135 || dates.Age < 0)
            {
                return Redirect("/Home/Index");
            }
            if (dates.isBirthday())
            {
                ViewBag.Whishes = "Happy Birthday to you!";
            }
          
            return View(dates);
        }

   
    }
}


