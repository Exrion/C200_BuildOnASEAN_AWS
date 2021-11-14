using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login.Models;
using Microsoft.AspNetCore.Http;


namespace TestArea.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public ActionResult Verify(Account acc)
        {


            IFormCollection form = HttpContext.Request.Form;
            String username = form["username"].ToString().Trim();
            String password = form["password"].ToString().Trim();

            if (ValidUtl.CheckIfEmpty(username, password))
            {
                ViewData["Message"] = "Please enter all fields";
                return View("login");


            }

            return View("Home");
        }
    }
}
