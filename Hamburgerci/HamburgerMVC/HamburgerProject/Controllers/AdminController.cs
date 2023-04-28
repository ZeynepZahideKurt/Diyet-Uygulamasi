using Microsoft.AspNetCore.Mvc;

namespace HamburgerProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
