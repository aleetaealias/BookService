using Microsoft.AspNetCore.Mvc;

namespace BookServiceApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}