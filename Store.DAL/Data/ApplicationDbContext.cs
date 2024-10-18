using Humanizer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store.DAL.Models;

namespace Store.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Seed Data
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var RoleSuperAdminId = Guid.NewGuid().ToString();
            var RoleAdminId = Guid.NewGuid().ToString(); 
            var RoleUserId = Guid.NewGuid().ToString();
            builder.Entity<IdentityRole>().HasData(
                
                new IdentityRole { Id= RoleSuperAdminId, Name="superadmin", NormalizedName="SUPERADMIN" },
                new IdentityRole { Id= RoleAdminId, Name="admin", NormalizedName="ADMIN" }, 
                new IdentityRole { Id= RoleUserId, Name="user", NormalizedName="USER" }
                
                );

            var hasher = new PasswordHasher<ApplicationUser>();


            var superAdmin = new ApplicationUser
            {
                UserName = "superadmin@comp.com",
                NormalizedUserName = "SUPERADMIN@COMP.COM",
                Email = "superadmin@comp.com",
                NormalizedEmail = "SUPERADMIN@COMP.COM",
                EmailConfirmed = true,


            };
            superAdmin.PasswordHash = hasher.HashPassword(superAdmin, "Abdelrahman!123");


            var adminUser = new ApplicationUser
            {
                UserName = "admin@comp.com",
                NormalizedUserName = "ADMIN@COMP.COM",
                Email = "admin@comp.com",
                NormalizedEmail = "ADMIN@COMP.COM",
                EmailConfirmed = true,


            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "Abdelrahman!123");


           
            var user = new ApplicationUser
               {
                UserName = "user@comp.com",
                NormalizedUserName="USER@COMP.COM",
                Email= "user@comp.com",
                NormalizedEmail= "USER@COMP.COM",
                EmailConfirmed =true,


              };
            user.PasswordHash = hasher.HashPassword(user, "Abdelrahman!123");

            builder.Entity<ApplicationUser>().HasData(superAdmin, adminUser, user);
            builder.Entity<IdentityUserRole<string>>().HasData(


                new IdentityUserRole<string> { RoleId= RoleSuperAdminId, UserId=superAdmin.Id, },
                new IdentityUserRole<string> { RoleId= RoleAdminId, UserId = adminUser.Id, },
                new IdentityUserRole<string> { RoleId= RoleUserId, UserId= user.Id, }
                
                
                );
        
        
        }



        public DbSet<Services> Services { get; set; }
     


    }
}
