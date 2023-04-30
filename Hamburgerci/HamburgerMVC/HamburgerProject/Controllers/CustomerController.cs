using AutoMapper;
using HamburgerProject.Entity.Concrete;
using HamburgerProject.Models;
using HamburgerProject.Models.Admin;
using HamburgerProject.Models.Customer;
using HamburgerProject.Repositories.Abstract;
using HamburgerProject.Repositories.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;

namespace HamburgerProject.Controllers
{
    public class CustomerController : Controller
    {
        /* Order view sayfası CRUD işlemleri
         Create action OK Create VİEW NOT_OK (Authentication bağlantılı userid taşıma yapılmalı)
         Update action NOT_OK Update VİEW NOT_OK
         Delete action NOT_OK Delete VİEW NOT_OK
         List action NOT_OK ListVİEW NOT_OK (ZEHRA)
         Authentication işlemleri
         Seed'e 2 3 adet veri ekle(Menu Extra)
        */
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
       
        public async Task<IActionResult> OrderAdd() 
        {

            var menuList = menuGenericRepository.GetAll().ToList();
            var extraList = extraGenericRepository.GetAll().ToList();
            int id = 5;
            var user = await userManager.FindByIdAsync(id.ToString());
            Order order = new Order();
            order.AppUser = user;
            bool result = orderRepository.Add(order);
            if (result)
            {
                AddOrderVM orderList = new AddOrderVM();
                orderList.AdminMenus = menuList;
                orderList.AdminExtras = extraList;
                orderList.OrderId = order.Id;
                orderList.UserId = order.AppUser.Id;
                return View(orderList);
            }

            return View();
            
        }
        [HttpPost]
        public async Task<IActionResult> OrderAdd(AddOrderVM orderList)
        {
            

            if (!ModelState.IsValid)
            {
                return View();
            }
            Order order = orderRepository.GetById(orderList.OrderId);
            var menu = menuGenericRepository.GetById(orderList.MenuId);
            var extra = extraGenericRepository.GetById(orderList.ExtraId);
            var user = await userManager.FindByIdAsync(orderList.UserId.ToString());
            order.Menus.Add(menu);
            order.Extras.Add(extra);
            order.AppUser = user;
            order.CreatedTime = orderList.CreateTime;
            orderRepository.Calculate(order);

            orderList.AdminMenus= menuGenericRepository.GetAll().ToList();
            orderList.AdminExtras= extraGenericRepository.GetAll().ToList();

            orderList.CustomerMenus.Add(menu);
            orderList.CustomerExtras.Add(extra);
            orderList.OrderId = order.Id;
            //orderList.CustomerMenus.Add(menu);
            //orderList.CustomerExtras.Add(extra);
            //orderList.Totalprice = order.TotalPrice;
            //var menuList = menuGenericRepository.GetAll().ToList();
            //var extraList = extraGenericRepository.GetAll().ToList();
            //orderList.AdminExtras = extraList;
            //orderList.AdminMenus = menuList;
            bool result = orderRepository.Update(order);

            if (result)
            {
                TempData["Bildiri"] = "İşlem Başarılı";
                return View(orderList);
            }


            ViewBag.Bildiri = "İşlem Başarılı olamadı";
            return View(orderList);

        }
    }
}
