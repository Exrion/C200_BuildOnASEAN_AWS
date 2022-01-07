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
        //TODO Create checks for roles and users and create them if not exists
        public static void createDefaultSuper()
        {
            if (!LoadUsersAndRoles.FindSuperUser())
            {
                string sql = @"INSERT INTO Users(Id, Email, Passw";
            }
        }
    }
}
