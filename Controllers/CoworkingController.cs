using Microsoft.AspNetCore.Mvc;

namespace CoworkingSpaceApp.Controllers
{
    public class CoworkingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Space()
        {
            return View();
        }
    }
}
