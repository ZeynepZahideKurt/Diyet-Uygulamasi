using AutoMapper;
using HamburgerProject.Entity.Concrete;
using HamburgerProject.Models;

namespace HamburgerProject.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<UserSignUpVM, AppUser>().ReverseMap(); //UserVM'i appusera eklenir
        }
    }
}
