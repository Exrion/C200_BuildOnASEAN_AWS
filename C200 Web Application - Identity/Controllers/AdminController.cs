using C200_Web_Application___Identity.Models;
using C200_Web_Application___Identity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        #region Homepage/Index - VIEW
        public IActionResult Index()
        {
            return View("Dashboard");
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        #endregion

        #region Cameras - VIEW
        public IActionResult Cameras()
        {
            return View();
        }
        #endregion

        #region Contacts - VIEW
        public IActionResult Contacts()
        {
            var sdaMain = GetSDAMain();
            return View(sdaMain);
        }
        [HttpGet]
        public IActionResult Contacts_Location(string location)
        {
            TempData["Location"] = location;
            var sdaList = GetSDAList(location);
            return View(sdaList);
        }
        private List<SDA> GetSDAList(string location)
        {
            string sql = @"SELECT OOF.Officer_id, OOF.Name, OOF.Contact_no, OOF.Dob, LO.Location_name AS Location, US.Id FROM Onsite_officers OOF INNER JOIN Location LO ON LO.Location_id = OOF.Location_Location_id INNER JOIN Users US ON US.Id = OOF.Users_Id WHERE US.Id = '{0}' AND LO.Location_name = '{1}'";
            List<SDA> sdaList = DBUtl.GetList<SDA>(sql, User.Identity.Name, location);
            //string sql = @"SELECT OOF.officer_id, OOF.name, OOF.contact_no, OOF.dob, LO.location_name AS location, US.Id FROM onsite_officers OOF INNER JOIN location LO ON LO.location_id = OOF.location_location_id INNER JOIN users US ON US.Id = OOF.users_Id WHERE US.Id = 'Normal_Admin' AND LO.location_name = 'CausewayPoint'";
            //List<SDA> sdaList = DBUtl.GetList<SDA>(sql);
            TempData["Location"] = location;
            return sdaList;
        }
        private List<SDAMAIN> GetSDAMain()
        {
            string sql = @"SELECT DISTINCT COUNT(OOF.Officer_id) AS Officer_count, LO.Location_name AS Location, US.Id FROM Onsite_officers OOF INNER JOIN Location LO ON LO.Location_id = OOF.Location_Location_id INNER JOIN Users US ON US.Id = OOF.Users_Id WHERE US.Id = '{0}'";
            List<SDAMAIN> sdaMain = DBUtl.GetList<SDAMAIN>(sql, User.Identity.Name);
            return sdaMain;
        }
        #endregion

        #region Analytics - VIEW
        public IActionResult Analytics()
        {
            return View();
        }
        #endregion

        #region FileDirectory - VIEW
        public IActionResult FileDirectory()
        {
            return View();
        }
        #endregion

        #region Display Users - VIEW
        //Super User
        [Authorize(Roles = "SU")]
        public IActionResult Users()
        {
            List<Users> usersList = LoadUsersAndRoles.GenUsersAndRoles();
            return View(usersList);
        }
        #endregion

        #region Edit User
        [Authorize(Roles = "SU")]
        [HttpGet]
        public IActionResult EditUser(string id)
        {
            var user = LoadUsersAndRoles.FindUser(id);

            if (user == null)
            {
                TempData["Error_type"] = "alert-danger";
                TempData["Error_msg"] = string.Format("User ID {0} mismatch", id);
                return RedirectToAction("Users");
            }
            return View(user);
        }
        [Authorize(Roles = "SU")]
        [HttpPost]
        public IActionResult EditUser(Users updateUser)
        {
            var user = LoadUsersAndRoles.FindUser(updateUser.Id);

            if (user == null)
            {
                TempData["Error_type"] = "alert-danger";
                TempData["Error_msg"] = string.Format("User ID {0} mismatch", updateUser.Id);
                return RedirectToAction("Users");
            }
            else
            {
                user.Email = updateUser.Email;
                user.UserName = updateUser.UserName;

                string sql = @"UPDATE Users SET Username='{0}', Email='{1}' WHERE Id='{2}'";
                int rows = DBUtl.ExecSQL(string.Format(sql, DBUtl.EscQuote(user.UserName), DBUtl.EscQuote(user.Email), updateUser.Id));

                if (rows == 1)
                {
                    TempData["Error_type"] = "alert-info";
                    TempData["Error_msg"] = "User data updated";
                    return RedirectToAction("Users");
                }
                else
                {
                    TempData["Error_type"] = "alert-warning";
                    TempData["Error_msg"] = "User data not updated";
                    return RedirectToAction("Users");
                }
            }
        }
#endregion

        #region Delete User
        [Authorize(Roles = "SU")]
        //Delete User Button
        public IActionResult DeleteUser(string id)
        {
            var user = LoadUsersAndRoles.FindUser(id);

            if (user == null)
            {
                TempData["Error_type"] = "alert-danger";
                TempData["Error_msg"] = string.Format("User ID {0} mismatch", id);
                return RedirectToAction("Users");
            }
            else
            {
                string sql = @"DELETE FROM Users WHERE Id='{0}'";
                int rows = DBUtl.ExecSQL(String.Format(sql, id));

                if (rows == 1)
                {
                    TempData["Error_type"] = "alert-info";
                    TempData["Error_msg"] = "User deleted";
                    return RedirectToAction("Users");
                }
                else
                {
                    TempData["Error_type"] = "alert-warning";
                    TempData["Error_msg"] = "Delete Unsuccessful";
                    return RedirectToAction("Users");
                }
            }
        }
        #endregion

        #region Create User
        [Authorize(Roles = "SU")]
        [HttpGet]
        //Create User Button
        public IActionResult CreateUser()
        {
            return View();
        }

        [Authorize(Roles = "SU")]
        [HttpPost]
        //Create User Button
        public IActionResult CreateUser(Users user)
        {
            if (LoadUsersAndRoles.FindUser(user.Id) != null)
            {
                TempData["Error_type"] = "alert-danger";
                TempData["Error_msg"] = string.Format("User ID must be unique", user.Id);
                return RedirectToAction("Users");
            }
            else
            {
                bool success = RoleAndUser_Create.createUser(user.Id, user.Email, user.Password, user.UserName);

                if (success)
                {
                    TempData["Error_type"] = "alert-info";
                    TempData["Error_msg"] = "User Added";
                    return RedirectToAction("Users");
                }
                else
                {
                    TempData["Error_type"] = "alert-warning";
                    TempData["Error_msg"] = "Create Unsuccessful, there may be a duplicate User ID!";
                    return RedirectToAction("Users");
                }
            }
        }
        #endregion

        #region Deserialise Camera

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

        #endregion

        #region Display Organisation (Partners) -VIEW
        //Super User
        [Authorize(Roles = "SU")]
        public IActionResult Organisations()
        {
            List<Organisation> organisationList = DBUtl.GetList<Organisation>("SELECT Organisation_id, Company_name, Email_address, Description FROM Organisation");
            return View("Organisations", organisationList);
        }
        #endregion

        #region Create Organisation (Partners)
        [Authorize(Roles = "SU")]
        [HttpGet]
        //Create Organisation Button
        public IActionResult CreateOrganisation()
        {
            return View();
        }

        [Authorize(Roles = "SU")]
        [HttpPost]
        //Create Organisation Button
        public IActionResult CreateOrganisation(Organisation organisation)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Message"] = "Invalid Input";
                ViewData["MsgType"] = "warning";
                return View("CreateOrganisation");
            }
            else
            {
                string insertSQL = @"INSERT INTO Organisation(Organisation_id, Company_name, Description, Email_address)
                                    VALUES ({0},'{1}','{2}','{3}')";

                if (DBUtl.ExecSQL(insertSQL, organisation.Organisation_id, organisation.Company_name, organisation.Description, organisation.Email_address ) == 1)
                {
                    TempData["Message"] = "New Partner Created";
                    TempData["MsgType"] = "success";
                }
                else
                {
                    TempData["Message"] = DBUtl.DB_Message;
                    TempData["MsgType"] = "danger";
                }
                return RedirectToAction("Organisations");
            }
        }
        #endregion

    }
}