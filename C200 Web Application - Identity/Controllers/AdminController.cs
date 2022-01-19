﻿using C200_Web_Application___Identity.Models;
using C200_Web_Application___Identity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
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
            return View();
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

                string sql = @"UPDATE users SET username='{0}', email='{1}' WHERE Id='{2}'";
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
                string sql = @"DELETE FROM users WHERE Id='{0}'";
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