namespace KiyaslaProje.Infrasturcture.Migrations
{
    using KiyaslaProje.Domain.Entities;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KiyaslaProje.Infrasturcture.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(KiyaslaProje.Infrasturcture.ApplicationDbContext context)
        {
            //CreateRoles(context);
            //CreateAdminUser(context);    
        }

        private void CreateAdminUser(ApplicationDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var user = userManager.FindByNameAsync("admin").Result;
            if (user == null)
            {
                user = new ApplicationUser { UserName = "admin", Email = "igedikoglugs@hotmail.com", EmailConfirmed = true };
                userManager.Create(user, "Ddrasd1996!");
                userManager.AddToRole(user.Id, "admin");
            }

            var userInRole = userManager.IsInRole(user.Id, "admin");
            if (!userInRole)
            {
                userManager.AddToRole(user.Id, "admin");
            }
        }

        private void CreateRoles(ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            string[] roleNames = { "admin", "user" };

            foreach (var role in roleNames)
            {
                if (roleManager.RoleExists(role) == false)
                {
                    var newRole = new IdentityRole { Name = role };
                    roleManager.Create(newRole);
                }
            }
        }
    }
}
