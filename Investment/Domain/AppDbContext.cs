using Investment.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "3210e1e0-b2c2-11ed-afa1-0242ac120002",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3210e564-b2c2-11ed-afa1-0242ac120002",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "MyEmail@Gmail.com",
                NormalizedEmail = "MYEMAIL@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            }); ;
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "3210e1e0-b2c2-11ed-afa1-0242ac120002",
                UserId = "3210e564-b2c2-11ed-afa1-0242ac120002"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("3210ebae-b2c2-11ed-afa1-0242ac120002 "),
                CodeWord = "PageIndex",
                Title = "მთავარი"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("3210ee24-b2c2-11ed-afa1-0242ac120002"),
                CodeWord = "PageServices",
                Title = "ჩვენი მომსახურება"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("59d61ca4-b2c2-11ed-afa1-0242ac120002"),
                CodeWord = "PageContacts",
                Title = "კონტაქტი"
            });
        }

    }
}
