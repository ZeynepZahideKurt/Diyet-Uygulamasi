﻿using AutoMapper;
using HamburgerProject.Entity.Concrete;
using HamburgerProject.Models;
using HamburgerProject.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HamburgerProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapper mapper;

        public LoginController(UserManager<AppUser> userManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.mapper = mapper;
          

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
                    return RedirectToAction("CustomerHome","Customer");
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
    }
}
