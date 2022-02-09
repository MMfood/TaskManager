using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Entities;

namespace TaskManager.Infrastructure.Seed
{
    public static class SeedRoles
    {
        public static void Roles(this ModelBuilder modelBuilder)
        {

            modelBuilder
                .Entity<UserRole>()
                .HasData(new IdentityRole
                {
                    Id = "a5e38752-84ae-4352-a0b6-bf47b3fd460a",
                    Name = "Manager",
                    NormalizedName = "MANAGER"
                });

            modelBuilder
                .Entity<UserRole>()
                .HasData(new IdentityRole
                {
                    Id = "a6e38752-84ae-4352-a0b6-bf47b3fd460a",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                });


            modelBuilder
              .Entity<UserRole>()
              .HasData(new IdentityRole
              {
                  Id = "d90e75c6-7da9-490e-aeb0-3d8c4827e193",
                  Name = "Performer",
                  NormalizedName = "PERFORMER"
              });



            var hasher = new PasswordHasher<User>();


            var adminAdmin = new User
            {
                Id = "79e7930c-3df5-4261-99cf-0352eb018a91",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                SecurityStamp = "6I5VNHIJTSZNOT3KDWKNFUV5PVYBHGXN",
                LockoutEnabled = true
            };



            adminAdmin.PasswordHash = hasher
                .HashPassword(adminAdmin, "12345");




            modelBuilder.Entity<User>()
                .HasData(adminAdmin);



            modelBuilder
                .Entity<IdentityUserRole<string>>()
                .HasData(new IdentityUserRole<string>
                { UserId = adminAdmin.Id, RoleId = "a6e38752-84ae-4352-a0b6-bf47b3fd460a" });


        }
    }
}
