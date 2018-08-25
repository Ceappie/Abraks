namespace Abraks.Web.Extensions
{
    using System;
    using System.Linq;
    using Abraks.Data;
    using Abraks.Models;
    using Common.Constants;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    public static class AppBuilderAuthExtensions
    {
        //TO DO: Moderator Role
        private static readonly IdentityRole[] roles =
        {
            new IdentityRole("Administrator")
        };

        public static async void SeedDatabase(this IApplicationBuilder app)
        {
            var serviceFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            var scope = serviceFactory.CreateScope();
            using (scope)
            {
                RoleManager<IdentityRole> roleManger = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                UserManager<User> userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

                foreach (var role in roles)
                {
                    if (!await roleManger.RoleExistsAsync(role.Name))
                    {
                        await roleManger.CreateAsync(role);
                    }
                }

                User user = await userManager.FindByNameAsync(StringConstants.AdminUsername);
                if (user == null)
                {
                    user = new User()
                    {
                       UserName = StringConstants.AdminUsername,
                       Email = StringConstants.AdminEmail,
                       FullName = StringConstants.AdminUsername
                    };

                    await userManager.CreateAsync(user, StringConstants.DefaultAdminPassword);
                    await userManager.AddToRoleAsync(user, roles[0].Name);
                }
            }
        }

        public static void SeedData(this IApplicationBuilder app)
        {
            using (IServiceScope serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                AbraksContext db = serviceScope.ServiceProvider.GetService<AbraksContext>();

                DanceType initialDance = db.DanceTypes.FirstOrDefault(t => t.Name == "Folklor");
                if (initialDance == null)
                {
                    db.DanceTypes.Add(new DanceType()
                    {
                        Name = "Folklor"
                    });
                    db.DanceTypes.Add(new DanceType()
                    {
                        Name = "Salsa"
                    });
                }
                db.SaveChanges();

                Event initialEvent = db.Events.FirstOrDefault(c => c.Name == "Gergiovden");
                if (initialEvent == null)
                {
                    db.Events.Add(new Event()
                    {
                        Name = "Gergiovden",
                        Place = "Stefanovo",
                        Address = "Stefanovo",
                        Dance = initialDance,
                        PosterUrl = "https://imageshack.com/a/img924/5145/O5s8hO.jpg",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(2)
                    });
                }
                db.SaveChanges();
            }
        }
    }
}
