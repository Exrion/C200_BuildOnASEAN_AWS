using C200_Web_Application___Identity.Areas.Identity.Data;
using C200_Web_Application___Identity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<WebAppUser> userManager;

        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<WebAppUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Cameras()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Analytics()
        {
            return View();
        }
        public IActionResult FileDirectory()
        {
            return View();
        }
        [Authorize(Roles = "SU")]

        //Super User
        [Authorize(Roles = "SU")]
        public IActionResult Users()
        {
            var users = userManager.Users;
            return View(users);
        }
        [Authorize(Roles = "SU")]
        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                TempData["Error_type"] = "alert-danger";
                TempData["Error_msg"] = string.Format("User ID {0} mismatch", id);
                return RedirectToAction("Users");
            }

            var userClaims = await userManager.GetClaimsAsync(user);
            var userRoles = await userManager.GetRolesAsync(user);

            var model = new EditUserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Claims = userClaims.Select(c => c.Value).ToList(),
                Roles = (List<string>)userRoles
            };

            return View(model);
        }
        [Authorize(Roles = "SU")]
        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                TempData["Error_type"] = "alert-danger";
                TempData["Error_msg"] = string.Format("User ID {0} mismatch", model.Id);
                return RedirectToAction("Users");
            }
            else
            {
                user.Email = model.Email;
                user.UserName = model.UserName;

                var result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    TempData["Error_type"] = "alert-info";
                    TempData["Error_msg"] = "User data updated";
                    return RedirectToAction("Users");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        
        //Delete User Button
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                TempData["Error_type"] = "alert-danger";
                TempData["Error_msg"] = string.Format("User ID {0} mismatch", id);
                return RedirectToAction("Users");
            }
            else
            {
                var result = await userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    TempData["Error_type"] = "alert-info";
                    TempData["Error_msg"] = "User deleted";
                    return RedirectToAction("Users");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("Users");
            }
        }


    }
}
