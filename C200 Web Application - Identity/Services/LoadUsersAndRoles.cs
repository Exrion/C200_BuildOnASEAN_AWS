using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using C200_Web_Application___Identity.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace C200_Web_Application___Identity.Services
{
    public class LoadUsersAndRoles
    {
        //Load Users and Roles
        public static List<Users> GenUsersAndRoles()
        {
            string sql = @"SELECT* FROM Users";
            List<Users> UsersAndRoles = DBUtl.GetList<Users>(sql);
            return UsersAndRoles;
        }

        public static Users FindUser(string id)
        {
            List<Users> UsersAndRoles = GenUsersAndRoles();
            foreach (Users user in UsersAndRoles)
            {
                if (user.id == id)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}
