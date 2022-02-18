using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RoleBasedAuthentication.Core.Utilities.Identity.Microsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleBasedAuthentication.Business.Constants
{
    public static class Seed
    {
        public static async Task CreateRoles(IServiceProvider serviceProvider, IConfiguration Configuration)
        {
            //adding customs roles
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            string[] roleNames = { "Admin", "Helper", "User" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                //creating the roles and seeding them to the database
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // => also you can send to admin auth informations from here except type in appsettings.json folder For some informations you should type in ApplicationUser class
            //var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            //var admin = new ApplicationUser
            //{
            //    UserName = "kurtulusocL",
            //    Email = "kurtulusocal@outlook.com",
            //    EmailConfirmed = true,
            //    IsConfirmed = true,
            //    Birthdate = DateTime.Now.ToLocalTime(),
            //    NameSurname = "Kurtulus Ocal",
            //    PhoneNumber = "296703253123",
            //    RespondTitle = "Admin",
            //};
            //await userManager.CreateAsync(admin, "ocL_1972");


            //creating a super user who could maintain the web app
            var poweruser = new ApplicationUser
            {
                UserName = Configuration.GetSection("AppSettings")["UserEmail"],
                Email = Configuration.GetSection("AppSettings")["UserEmail"]
            };

            string userPassword = Configuration.GetSection("AppSettings")["UserPassword"];
            var user = await UserManager.FindByEmailAsync(Configuration.GetSection("AppSettings")["UserEmail"]);

            if (user == null)
            {
                var createPowerUser = await UserManager.CreateAsync(poweruser, userPassword);
                if (createPowerUser.Succeeded)
                {
                    //here we tie the new user to the "Admin" role 
                    await UserManager.AddToRoleAsync(poweruser, "Admin");

                }
            }
        }
    }
}
