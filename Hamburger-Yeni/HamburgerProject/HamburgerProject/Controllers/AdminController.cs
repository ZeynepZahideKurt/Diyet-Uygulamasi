using AutoMapper;
using HamburgerProject.Entity.Concrete;
using HamburgerProject.Models.Admin;
using HamburgerProject.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HamburgerProject.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly IRepository<Product> productGenericRepository;
        
        private readonly IMapper mapper;

        public AdminController(IRepository<Product> productGenericRepository, IMapper mapper)
        {
            this.productGenericRepository = productGenericRepository;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {

            var productList = productGenericRepository.GetAll().ToList();
            ListVM list = new ListVM();
            list.Products = productList;
            return View(list);

        }



        public IActionResult ProductCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProductCreate(ProductCreateVM productCreateVM)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            Product product = mapper.Map<Product>(productCreateVM); //Destination: elime geçecek şey
            bool result = productGenericRepository.Add(product);

            if (result)
            {
                TempData["Bildiri"] = "İşlem Başarılı";
                return RedirectToAction("Index");
            }
            ViewBag.Bildiri = "İşlem Başarılı olamadı";
            return View(productCreateVM);
        }
       

        public IActionResult ProductUpdate(int id)
        {
            Product product = productGenericRepository.GetById(id);
            ProductUpdateVM productUpdateVM = mapper.Map<ProductUpdateVM>(product);
            return View(productUpdateVM);
        }
        [HttpPost]
        public IActionResult MenuUpdate(ProductUpdateVM productUpdateVM)
        {
            try
            {
                Product product = productGenericRepository.GetById(productUpdateVM.Id);
                mapper.Map(productUpdateVM, product);


                bool result = productGenericRepository.Update(product);

                if (result)
                {
                    TempData["Bildiri"] = "İşlem Başarılı";
                    return RedirectToAction("Index");
                }
                ViewBag.Bildiri = "İşlem Başarılı olamadı";

                return View(productUpdateVM);
            }
            catch (Exception)
            {
                return View(productUpdateVM);
            }
        }

        public IActionResult ProductDelete(int id)
        {
            Product product = productGenericRepository.GetById(id);
            bool result = productGenericRepository.Delete(product);

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
