using Microsoft.AspNetCore.Mvc;

namespace Lab11.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}