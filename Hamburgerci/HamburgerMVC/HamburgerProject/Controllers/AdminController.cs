using AutoMapper;
using HamburgerProject.Entity.Concrete;
using HamburgerProject.Models.Admin;
using HamburgerProject.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HamburgerProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRepository<Menu> menuGenericRepository;
        private readonly IRepository<Extra> extraGenericRepository;
        private readonly IMapper mapper;

        public AdminController(IRepository<Menu> menuGenericRepository, IRepository<Extra> extraGenericRepository, IMapper mapper)
        {
            this.menuGenericRepository = menuGenericRepository;
            this.extraGenericRepository = extraGenericRepository;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            
            var extraList = extraGenericRepository.GetAll().ToList();
            var menuList = menuGenericRepository.GetAll().ToList();
            ListVM list = new ListVM();
            list.Menus = menuList ;
            list.Extras =extraList;
            return View(list);

        }
        
            

        public IActionResult MenuCreate() {
            return View();
        }

        [HttpPost]
        public IActionResult MenuCreate(MenuCreateVM menuCreateVM) {

            if (!ModelState.IsValid)
            {
                return View();
            }
            Menu menu = mapper.Map<Menu>(menuCreateVM); //Destination: elime geçecek şey



            bool result = menuGenericRepository.Add(menu);



            if (result)
            {
                TempData["Bildiri"] = "İşlem Başarılı";
                return RedirectToAction("Index");
            }
            ViewBag.Bildiri = "İşlem Başarılı olamadı";
            return View(menuCreateVM);
        }
        public IActionResult ExtraCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ExtraCreate(ExtraCreateVM extraCreateVM)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            Extra extra = mapper.Map<Extra>(extraCreateVM); //Destination: elime geçecek şey



            bool result = extraGenericRepository.Add(extra);



            if (result)
            {
                TempData["Bildiri"] = "İşlem Başarılı";
                return RedirectToAction("Index");
            }
            ViewBag.Bildiri = "İşlem Başarılı olamadı";
            return View(extraCreateVM);
        }

        public IActionResult MenuUpdate(int id)
        {
            Menu menu = menuGenericRepository.GetById(id);
            MenuUpdateVM menuUpdateVM = mapper.Map<MenuUpdateVM>(menu);
            return View(menuUpdateVM);
        }
        [HttpPost]
        public IActionResult MenuUpdate(MenuUpdateVM menuUpdateVM)
        {
            try
            {
                Menu menu = menuGenericRepository.GetById(menuUpdateVM.Id);
                 mapper.Map(menuUpdateVM, menu);


                bool result = menuGenericRepository.Update(menu);

                if (result)
                {
                    TempData["Bildiri"] = "İşlem Başarılı";
                    return RedirectToAction("Index");
                }
                ViewBag.Bildiri = "İşlem Başarılı olamadı";

                return View(menuUpdateVM);
            }
            catch (Exception)
            {
                return View(menuUpdateVM);
            }
        }

        public IActionResult ExtraUpdate(int id)
        {
            Extra extra = extraGenericRepository.GetById(id);
            ExtraUpdateVM extraUpdateVM = mapper.Map<ExtraUpdateVM>(extra);
            return View(extraUpdateVM);
        }
        [HttpPost]
        public IActionResult ExtraUpdate(ExtraUpdateVM extraUpdateVM)
        {
            try
            {
                Extra extra = extraGenericRepository.GetById(extraUpdateVM.Id);
                mapper.Map(extraUpdateVM, extra);


                bool result = extraGenericRepository.Update(extra);

                if (result)
                {
                    TempData["Bildiri"] = "İşlem Başarılı";
                    return RedirectToAction("Index");
                }
                ViewBag.Bildiri = "İşlem Başarılı olamadı";

                return View(extraUpdateVM);
            }
            catch (Exception)
            {
                return View(extraUpdateVM);
            }
        }

        public IActionResult MenuDelete(int id)
        {
            Menu menu = menuGenericRepository.GetById(id);
            bool result = menuGenericRepository.Delete(menu);

            if (result)
            {
                TempData["Bildiri"] = "İşlem Başarılı";
                return RedirectToAction("Index");
            }
            ViewBag.Bildiri = "İşlem Başarılı olamadı";

            return View(id);
        }
        public IActionResult ExtraDelete(int id)
        {
            Extra extra = extraGenericRepository.GetById(id);
            bool result = extraGenericRepository.Delete(extra);

            if (result)
            {
                TempData["Bildiri"] = "İşlem Başarılı";
                return RedirectToAction("Index");
            }
            ViewBag.Bildiri = "İşlem Başarılı olamadı";

            return View(id);
        }

    }
}
