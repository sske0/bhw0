using Microsoft.AspNetCore.Mvc;

namespace bhw1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Ali";
            ViewBag.Surname = "Aliyev";
            ViewBag.Age = 25;
            ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = "+994551234567";

            return View();
        }
    }
}
