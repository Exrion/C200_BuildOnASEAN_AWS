using C200_Web_Application___Identity.Areas.Identity.Data;
using C200_Web_Application___Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Models
{
    public static class SUCreate
    {
        public static void SeedData(UserManager<WebAppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<WebAppUser> userManager)
        {
            if (userManager.FindByEmailAsync("su@gmail.com").Result == null)
            {
                WebAppUser user = new WebAppUser();
                user.UserName = "su@gmail.com";
                user.Email = "su@gmail.com";

                IdentityResult result = userManager.CreateAsync(user, "SUser1234!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "SU").Wait();
                }
            }
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("SU").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "SU";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
            
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
        }

    }
}
