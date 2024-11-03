using BordroOtomasyon.Domain.Entites;
using BordroOtomasyon.Domain.Enums;
using BordroOtomasyon.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BordroOtomasyon.Infrastructure.Seeds
{
    public static class AdminSeed
    {
        private const string adminEmail = "adminadmin@admin.com";
        private const string adminPassword = "Password.91";

        public static async Task SeedAsync(IConfiguration configuration)
        {
            var contextBuilder = new DbContextOptionsBuilder<AppDbContext>();
            contextBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            AppDbContext context = new AppDbContext(contextBuilder.Options);

            if (!context.Roles.Any())
            {
                await AddRolesAsync(context);
            }
            if (!context.Users.Any(user => user.Email == adminEmail))
            {
                await AddAdminAsync(context);
            }

        }

        private static async Task AddAdminAsync(AppDbContext context)
        {
            IdentityUser user = new IdentityUser()
            {
                Email = adminEmail,
                EmailConfirmed = true,
                NormalizedEmail = adminEmail.ToUpperInvariant(),
                UserName = adminEmail,
                NormalizedUserName = adminEmail.ToUpperInvariant()

            };
            user.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(user, adminPassword);
            await context.Users.AddAsync(user);

            var adminRoleId = context.Roles.FirstOrDefault(role => role.Name == Roles.Admin.ToString()).Id;


            IdentityUserRole<string> userRole = new IdentityUserRole<string>()
            {
                RoleId = adminRoleId,
                UserId = user.Id

            };
            await context.UserRoles.AddAsync(userRole);

            await context.Admins.AddAsync(new Admin()
            {
                FullName = "admin",
                Email = adminEmail,
                IdentityId = user.Id

            });
            await context.SaveChangesAsync();
        }

        private static async Task AddRolesAsync(AppDbContext context)
        {
            string[] roles = Enum.GetNames(typeof(Roles));

            for (int i = 0; i < roles.Length; i++)
            {
                if (await context.Roles.AnyAsync(role => role.Name == roles[i]))
                {
                    continue;
                }
                IdentityRole role = new IdentityRole()
                {
                    Name = roles[i],
                    NormalizedName = roles[i].ToUpperInvariant()
                };
                await context.Roles.AddAsync(role);
                await context.SaveChangesAsync();


            }
        }
    }
}
