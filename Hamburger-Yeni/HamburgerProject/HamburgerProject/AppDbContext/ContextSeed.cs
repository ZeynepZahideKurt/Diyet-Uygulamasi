using HamburgerProject.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using System;

namespace HamburgerProject.AppDbContext
{
    public static class ContextSeed
    {
        public static async Task SeedRoleAsync(UserManager<AppUser>userManager, RoleManager<IdentityRole>roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Entity.Enums.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Entity.Enums.Roles.User.ToString()));
        }
    }
}
