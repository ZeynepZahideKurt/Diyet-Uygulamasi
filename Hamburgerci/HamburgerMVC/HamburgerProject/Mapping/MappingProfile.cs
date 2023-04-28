using AutoMapper;
using HamburgerProject.Entity.Concrete;
using HamburgerProject.Models;
using HamburgerProject.Models.Admin;

namespace HamburgerProject.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<UserSignUpVM, AppUser>().ReverseMap(); //UserVM'i appusera eklenir
            CreateMap<MenuCreateVM, Menu>().ReverseMap(); //UserVM'i appusera eklenir
            CreateMap<ExtraCreateVM, Extra>().ReverseMap(); //UserVM'i appusera eklenir
            CreateMap<MenuUpdateVM, Menu>().ReverseMap(); //UserVM'i appusera eklenir
            CreateMap<ExtraUpdateVM, Extra>().ReverseMap(); //UserVM'i appusera eklenir
        }
    }
}
