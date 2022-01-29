using C200_Web_Application___Identity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View("About_Us");
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Contact_Us()
        {
            return View();
        }

        public IActionResult About_Us()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SendEmail(IFormCollection form)
        {
            // Old Method of reading values from Forms
            string custname = form["CustName"].ToString().Trim();
            // Replace email with admin / SU
            string email = "20024377@myrp.edu.sg"; 
            string subject = form["Subject"].ToString().Trim();
            string message = form["Message"].ToString().Trim();

            string template = @"Hi you have an email from {0},
                               <p>{1}</p>
                            Customer Contact";  
            string body = String.Format(template, custname, message);
            string result;
            if (EmailUtl.SendEmail(email, subject, body, out result))
            {
                ViewData["Message"] = "Email Successfully Sent";
                ViewData["MsgType"] = "success";
            }
            else
            {
                ViewData["Message"] = result;
                ViewData["MsgType"] = "warning";
            }

            return View("Contact_us");
        }



    }
}
