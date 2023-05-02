using AutoMapper;
using HamburgerProject.Entity.Concrete;
using HamburgerProject.Models.Admin;
using HamburgerProject.Models.Customer;
using HamburgerProject.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HamburgerProject.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IMapper mapper;
        private readonly IOrderRepository orderRepository;
        private IRepository<Product> productGenericRepository;


        public CustomerController( IMapper mapper, IOrderRepository orderRepository,IRepository<Product> productGenericRepository)
        {
            this.mapper = mapper;
            this.orderRepository = orderRepository;
            this.productGenericRepository = productGenericRepository;
        }
        public IActionResult CustomerHome()
        {
            var productList = productGenericRepository.GetAll().ToList();
            FillToChartVM fillToChartVM = new FillToChartVM();
            fillToChartVM.Products=productList;
            return View(fillToChartVM);
        }

    }
}
