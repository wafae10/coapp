using Microsoft.AspNetCore.Mvc;

namespace CoworkingSpaceApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
