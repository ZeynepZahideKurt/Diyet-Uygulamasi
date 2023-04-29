using AutoMapper;
using HamburgerProject.Entity.Concrete;
using HamburgerProject.Models;
using HamburgerProject.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HamburgerProject.Controllers
{
    public class CustomerController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapper mapper;
        private readonly IOrderRepository orderRepository;
        private IRepository<Menu> menuGenericRepository;
        private readonly IRepository<Extra> extraGenericRepository;

        public CustomerController(UserManager<AppUser> userManager, IRepository<Menu> menuGenericRepository, IRepository<Extra> extraGenericRepository, IMapper mapper, IOrderRepository orderRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.orderRepository = orderRepository;
            this.menuGenericRepository = menuGenericRepository;
            this.extraGenericRepository = extraGenericRepository;
            
        }
        
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

       
        [HttpPost]
        public async Task<IActionResult> Register(UserSignUpVM userSignUpVM)
        {
            if (ModelState.IsValid)
            {

                AppUser user = mapper.Map<AppUser>(userSignUpVM);

                IdentityResult result = await userManager.CreateAsync(user, userSignUpVM.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("CustomerHome");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("User Sign Up", $"{error.Code}-{error.Description}");
                    }
                }
            }
            return View(userSignUpVM);
        }
        public IActionResult Index()
        {
            var orderlist=orderRepository.GetAllMenuAndExtras();

            return View(orderlist);
        }
        public IActionResult CustomerHome()
        {
            return View();
        }

        public IActionResult OrderAdd() 
        {
            
            return View();
        }
    }
}
