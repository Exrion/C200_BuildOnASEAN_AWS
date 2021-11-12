using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }

        public IActionResult Home()
        {
            return View("Home");
        }

        public IActionResult Cameras()
        {
            return View("Cameras_Admin");
        }

        public IActionResult Contacts()
        {
            return View("Contacts_Admin");
        }

        public IActionResult Analytics()
        {
            return View("Analytics_Admin");
        }

        //TEMP; REMOVE LATER
        public IActionResult Test()
        {
            return View("Test");
        }
    }
}
