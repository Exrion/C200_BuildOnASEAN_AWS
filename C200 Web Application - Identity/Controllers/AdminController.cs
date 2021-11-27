using C200_Web_Application___Identity.Areas.Identity.Data;
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
        [Authorize(Roles = "SU")]

        //Super User
        [Authorize(Roles = "SU")]
        public IActionResult Users()
        {
            var users = userManager.Users;
            return View(users);
        }
        [Authorize(Roles = "SU")]
        public async Task<IActionResult> EditUserAsync(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                TempData["UserID_Error"] = string.Format("User ID {0} mismatch", id);
                return RedirectToAction("Users");
            }
            else
            {
                return View("EditUser", user);
            }
        }
        [Authorize(Roles = "SU")]
        public async Task<IActionResult> DeleteUserAsync(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                TempData["UserID_Error"] = string.Format("User ID {0} mismatch", id);
                return RedirectToAction("Users");
            }
            else
            {
                return View("DeleteUser", user);
            }
        }
    }
}
