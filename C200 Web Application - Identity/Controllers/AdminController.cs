using C200_Web_Application___Identity.Models;
using C200_Web_Application___Identity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
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
            string sql = "SELECT C.Camera_id, C.Serial_no, C.Location_has_camera_Level_no, L.Location_name, C.Status " +
                "FROM Camera C " +
                "INNER JOIN Location_has_camera LC ON C.Location_has_camera_Level_no = LC.Level_no " +
                "INNER JOIN Location L ON LC.Location_Location_id = L.Location_id";
            List<Camera> cameraList = DBUtl.GetList<Camera>(sql);

            return View(cameraList);
        }
        #endregion

        #region Contacts - VIEW
        public IActionResult Contacts()
        {
            var sdaMain = GetSDAMain();
            return View(sdaMain);
        }
        public IActionResult Contacts_Location(string id)
        {
            TempData["Location"] = id;
            var sdaList = GetSDAList(id);
            return View(sdaList);
        }

        #region Edit Contact
        [HttpGet]
        public IActionResult EditContact(int id)
        {
            Contact contact = GetContact(id);
            Contact_Data contactData = Contact_Package.GetContactData();
            Contact_Package conPack = new Contact_Package(contact, contactData);
            return View(conPack);
        }
        [HttpPost]
        public IActionResult EditContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error_msg"] = "Invalid Input";
                TempData["Error_type"] = "alert-danger";
                return RedirectToAction("Contacts");
            }
            else
            {
                string sql = @"UPDATE Onsite_officers SET Name = '{1}', Contact_no = {2}, Dob = '{3:yyyy-MM-dd}' WHERE Officer_id = {0}";
                int result = DBUtl.ExecSQL(sql, contact.Officer_id, contact.Name, contact.Contact_no, contact.Dob);

                if (result == 1)
                {
                    TempData["Error_type"] = "alert-info";
                    TempData["Error_msg"] = "Contact data updated";
                }
                else
                {
                    TempData["Error_type"] = "alert-warning";
                    TempData["Error_msg"] = DBUtl.DB_Message;
                }
                return RedirectToAction("Contacts");
            }
        }
        #endregion

        #region Delete Contact
        public IActionResult DeleteContact(int id)
        {
            string sql = @"DELETE FROM Onsite_officers WHERE Officer_id = {0}";
            int result = DBUtl.ExecSQL(String.Format(sql, id));

            if (result == 1)
            {
                TempData["Error_type"] = "alert-info";
                TempData["Error_msg"] = "Contact deleted";
            }
            else
            {
                TempData["Error_type"] = "alert-warning";
                TempData["Error_msg"] = DBUtl.DB_Message;
            }
            return RedirectToAction("Contacts");
        }
        #endregion

        #region Create Contact
        [HttpGet]
        public IActionResult CreateContact()
        {
            Contact contact = null;
            Contact_Data contactData = Contact_Package.GetContactData();
            Contact_Package conPack = new Contact_Package(contact, contactData);
            return View(conPack);
        }
        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            string sql = @"INSERT INTO Onsite_officers(Officer_id, Name, Contact_no, Dob, Location_Location_id, Organisation_Organisation_id, Users_Id, Notification_Notification_id) VALUES({0}, '{1}', {2}, '{3:yyyy-MM-dd}', '{4}', {5}, '{6}', {7})";
            int result = DBUtl.ExecSQL(sql, contact.Officer_id, contact.Name, contact.Contact_no, contact.Dob, contact.Location_Location_id, contact.Organisation_Organisation_id, User.Identity.Name, contact.Notification_Notification_id);

            if (result == 1)
            {
                TempData["Error_type"] = "alert-info";
                TempData["Error_msg"] = "Contact added";
                return RedirectToAction("Contacts");
            }
            else
            {
                TempData["Error_type"] = "alert-warning";
                TempData["Error_msg"] = DBUtl.DB_Message;
                return RedirectToAction("Contacts");
            }
        }
        #endregion
        private List<SDA> GetSDAList(string location)
        {
            string sql = @"SELECT OOF.Officer_id, OOF.Name, OOF.Contact_no, OOF.Dob, LO.Location_name AS Location, US.Id FROM Onsite_officers OOF INNER JOIN Location LO ON LO.Location_id = OOF.Location_Location_id INNER JOIN Users US ON US.Id = OOF.Users_Id WHERE US.Id = '{0}' AND LO.Location_name = '{1}'";
            List<SDA> sdaList = DBUtl.GetList<SDA>(sql, User.Identity.Name, location);
            TempData["Location"] = location;
            return sdaList;
        }
        private Contact GetContact(int id)
        {
            Contact contact = null;
            string sql = @"SELECT OOF.Officer_id, OOF.Name, OOF.Contact_no, OOF.Dob, LO.Location_id, LO.Location_name, OG.Organisation_id, OG.Company_name, NT.Notification_id FROM Onsite_officers OOF INNER JOIN Location LO ON LO.Location_id = OOF.Location_Location_id INNER JOIN Organisation OG ON OG.Organisation_id = OOF.Organisation_Organisation_id INNER JOIN Notification NT ON NT.Notification_id WHERE OOF.Users_Id = '{0}' AND OOF.Officer_id = {1}";
            List<Contact> contactList = DBUtl.GetList<Contact>(sql, User.Identity.Name, id);
            if (contactList.Count != 1)
            {
                return contact;
            }
            else
            {
                contact = contactList[0];
                return contact;
            }
        }
        private List<SDAMAIN> GetSDAMain()
        {
            string sql = @"SELECT DISTINCT COUNT(OOF.Officer_id) AS Officer_count, LO.Location_name AS Location, OOF.Location_Location_id, US.Id FROM Onsite_officers OOF INNER JOIN Location LO ON LO.Location_id = OOF.Location_Location_id INNER JOIN Users US ON US.Id = OOF.Users_Id WHERE US.Id = '{0}'";
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

        #endregion

        #region Deserialise Camera

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

        #endregion

        #region Display Organisation (Partners) - VIEW
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
                ViewData["Error_type"] = "Invalid Input";
                ViewData["Error_msg"] = "warning";
                return View("CreateOrganisation");
            }
            else
            {
                string insertSQL = @"INSERT INTO Organisation(Organisation_id, Company_name, Description, Email_address)
                                    VALUES ({0},'{1}','{2}','{3}')";

                if (DBUtl.ExecSQL(insertSQL, organisation.Organisation_id, organisation.Company_name, organisation.Description, organisation.Email_address ) == 1)
                {
                    TempData["Error_msg"] = "New Partner Created";
                    TempData["Error_type"] = "success";
                }
                else
                {
                    TempData["Error_msg"] = DBUtl.DB_Message;
                    TempData["Error_type"] = "danger";
                }
                return RedirectToAction("Organisations");
            }
        }
        #endregion

        #region Edit Organisation (Partners)
        [Authorize(Roles = "SU")]
        [HttpGet]
        //Edit Organisation
        public IActionResult EditOrganisation(int id)
        {
            string selectSQL = @"SELECT * FROM Organisation WHERE Organisation_id = {0}";

            List<Organisation> organisationList = DBUtl.GetList<Organisation>(selectSQL, id);
            if (organisationList.Count == 1)
            {
               return View("EditOrganisation", organisationList[0]);
            }
            else
            {
                TempData["Error_msg"] = DBUtl.DB_Message; //Organisation Record does not exist
                TempData["Error_type"] = "warning";
                return RedirectToAction("Organisations");
            }
        }

        [Authorize(Roles = "SU")]
        [HttpPost]
        public IActionResult EditOrganisation(Organisation organisation)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Error_msg"] = "Invalid Input";
                ViewData["Error_type"] = "danger";
                return View("EditOrganisation");
            }
            else
            {
                string updateSQL = @"UPDATE Organisation  
                                    SET Company_name='{1}', Email_address='{2}', Description='{3}'
                                    WHERE Organisation_id={0}";

                if (DBUtl.ExecSQL(updateSQL, organisation.Organisation_id, 
                                       organisation.Company_name, 
                                       organisation.Email_address, 
                                       organisation.Description) == 1)
                {
                    TempData["Error_msg"] = "Partner Details Updated";
                    TempData["Error_type"] = "success";
                    return RedirectToAction("Organisations");
                }
                else
                {
                    TempData["Error_msg"] = DBUtl.DB_Message;
                    TempData["Error_type"] = "danger";
                    return RedirectToAction("Organisations");
                } 
            }
        }
        #endregion

        #region Delete Organisation
        [Authorize(Roles = "SU")]
        //Delete Organisation
        public IActionResult DeleteOrganisation(int id)
        {
            string deleteSQL = @"DELETE FROM Organisation WHERE Organisation_id={0}";
            int rowsAffected = DBUtl.ExecSQL(String.Format(deleteSQL, id));
            if (rowsAffected == 1)
            {
                TempData["Error_msg"] = "Organisation deleted";
                TempData["Error_type"] = "info";
                return RedirectToAction("Organisations");
            }
            else
            {
                TempData["Error_msg"] = DBUtl.DB_Message; //Delete Unsuccessful
                TempData["Error_type"] = "warning";
                return RedirectToAction("Organisations");
            }
        }
        #endregion

        #region Display Location - VIEW
        [Authorize(Roles = "SU")]
        public IActionResult Locations()
        {
            string insertSQL = @"SELECT Location.Location_id, Location.Location_name, Location.Address, 
                                MAX(Location_has_camera.Level_no), Location.Organisation_Organisation_id
								FROM Location_has_camera
                                INNER JOIN Location
                                ON Location.Location_id = Location_has_camera.Location_Location_id
                                GROUP BY Location_has_camera.Location_Location_id;";

            List<Location> locationList = DBUtl.GetList<Location>(insertSQL);
            return View("Locations", locationList);
        }
        #endregion

        #region Create Location
        private void PopulateViewData() 
        {
            DataTable organisationTable = DBUtl.GetTable("SELECT * FROM Organisation");
            ViewData["Organisations"] = organisationTable.Rows;

        }

        [Authorize(Roles = "SU")]
        [HttpGet]
        //Create Location
        public IActionResult CreateLocation()
        {
            return View();
        }

        [Authorize(Roles = "SU")]
        [HttpPost]
        //Create Location
        public IActionResult CreateLocation(Location location)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Error_type"] = "Invalid Input";
                ViewData["Error_msg"] = "warning";
                return View("CreateLocation");
            }
            else
            {
                string insertSQL = @"INSERT INTO Location(Location_id, Location_name, Address, Organisation_Organisation_id, Users_Id)
                                    VALUES ('{0}','{1}','{2}','{3}')";

                if (DBUtl.ExecSQL(insertSQL) == 1)
                {
                    TempData["Error_msg"] = "New Partner Created";
                    TempData["Error_type"] = "success";
                }
                else
                {
                    TempData["Error_msg"] = DBUtl.DB_Message;
                    TempData["Error_type"] = "danger";
                }
                return RedirectToAction("Locations");
            }
        }
        #endregion

        #region Edit Location
        #endregion

        #region Delete Location
        #endregion

        #region Display Camera - VIEW
        #endregion

        #region Create Camera
        #endregion

        #region Edit Camera
        #endregion

        #region Delete Camera
        #endregion

    }
}