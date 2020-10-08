using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_08.Models;

namespace Project_08.Models
{
    //public class Project_08Context : DbContext
    //{
    //    public Project_08Context (DbContextOptions<Project_08Context> options)
    //        : base(options)
    //    {
    //    }

    //    public DbSet<Project_08.Models.StudentModel> StudentModel { get; set; }
    //}


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });
        }


       


        public DbSet<Project_08.Models.MenuHelperModel> MenuHelperModel { get; set; }


        public DbSet<Project_08.Models.MenuModel> MenuModel { get; set; }


        public DbSet<Project_08.Models.MenuModelManage> MenuModelManage { get; set; }


        public DbSet<Project_08.Models.ApplicationRole> ApplicationRole { get; set; }


        public DbSet<Project_08.Models.ApplicationUserRole> ApplicationUserRole { get; set; }


        public DbSet<Project_08.Models.CarType> CarType { get; set; }


        public DbSet<Project_08.Models.Car> Car { get; set; }


        public DbSet<Project_08.Models.CarOrder> CarOrder { get; set; }


        public DbSet<Project_08.Models.OrderDetail> OrderDetail { get; set; }


    }



}
