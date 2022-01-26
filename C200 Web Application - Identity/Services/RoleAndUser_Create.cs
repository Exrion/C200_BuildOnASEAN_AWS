using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Services
{
    public static class RoleAndUser_Create 
    {
        /*
        private static readonly string ID = "Super_Default";
        private static readonly string USERNAME = ID;
        private static readonly string EMAIL = "Super_Default@gmail.com";
        private static readonly string PASSWORD = "SuperU123!";

        public static void createDefaultSuper()
        {
            string role = "SU";

            if (!LoadUsersAndRoles.FindSuperUser())
            {
                Console.WriteLine("Super User not found, seeding default super user...");

                string sql = @"INSERT INTO Users(Id, Email, Password, UserName, Role) VALUES('{0}', '{1}', SHA2('{2}', 256), '{3}', '{4}')";
                int result = DBUtl.ExecSQL(String.Format(sql, ID, EMAIL, PASSWORD, USERNAME, role));

                if (result == 1)
                {
                    Console.WriteLine("Super User Inserted");
                }
                else
                {
                    Console.WriteLine("Super User Insertion Unsuccessful");
                }
            }
        }
        */

        public static bool createUser(string id, string email, string password, string username)
        {
            string sql = @"INSERT INTO Users(Id, Email, Password, UserName, Role) VALUES('{0}', '{1}', SHA2('{2}', 256), '{3}', '{4}')";
            int result = DBUtl.ExecSQL(String.Format(sql, removeSpace(id), email, password, username, null));

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string removeSpace(string str)
        {
            if (str.Contains(" "))
            {
                str = str.Replace(" ", "_");
            }
            return str;
        }
    }
}
