using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application.Controllers
{
    public class AdminController : Controller
    {
        public void Main(string[] args)
        {

        }

        public IActionResult Index()
        {
            return View("Home_Content");
        }

        public IActionResult Home()
        {
            return View("Home_Content");
        }

        public IActionResult Cameras()
        {
            return View("Cameras_Content");
        }

        public IActionResult Contacts()
        {
            return View("Contacts_Content");
        }

        public IActionResult Analytics()
        {
            return View("Analytics_Content");
        }

        //TEMP; REMOVE LATER
        public IActionResult Test()
        {
            return View("Test");
        }
    }
}
