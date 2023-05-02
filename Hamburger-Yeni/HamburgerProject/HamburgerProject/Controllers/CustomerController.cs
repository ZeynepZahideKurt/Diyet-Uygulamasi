using Microsoft.AspNetCore.Mvc;

namespace HamburgerProject.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
