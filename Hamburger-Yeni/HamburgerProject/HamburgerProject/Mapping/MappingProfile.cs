using AutoMapper;
using HamburgerProject.Entity.Concrete;
using HamburgerProject.Models;
using HamburgerProject.Models.Admin;
//using HamburgerProject.Models.Customer;

namespace HamburgerProject.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<UserSignUpVM, AppUser>().ReverseMap(); //UserVM'i appusera eklenir
            CreateMap<ProductCreateVM, Product>().ReverseMap(); //UserVM'i appusera eklenir
            CreateMap<ProductUpdateVM, Product>().ReverseMap(); //UserVM'i appusera eklenir
            //CreateMap<AddOrderVM, Order>().ReverseMap(); //UserVM'i appusera eklenir
        }
    }
}
