using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentCourse.Data.Models;
using RentCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Data.EFContext
{
    public class EFDbContext : IdentityDbContext<DbUser, DbRole, string, IdentityUserClaim<string>,
   DbUserRole, IdentityUserLogin<string>,
   IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Models.Type> Types { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<FileModel> Files { get; set; }
        public virtual DbSet<UserFavorites> UserFavorites { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<DbUserRole>(userRole =>
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

            builder.Entity<UserFavorites>(userFavorites =>
            {
                userFavorites.HasKey(uf => new { uf.UserId, uf.ProductId });

                userFavorites.HasOne(uf => uf.User)
                .WithMany(u => u.UserFavorites)
                .HasForeignKey(uf => uf.UserId);

                userFavorites.HasOne(uf => uf.Product)
                .WithMany(f => f.UserFavorites)
                .HasForeignKey(uf => uf.ProductId);
            });
            //builder.Entity<UserFavorites>()
            //    .HasKey(uf => new { uf.UserId, uf.ProductId });
            //builder.Entity<UserFavorites>()
            //    .HasOne(uf => uf.User)
            //    .WithMany(u => u.UserFavorites)
            //    .HasForeignKey(uf => uf.UserId);
            //builder.Entity<UserFavorites>()
            //    .HasOne(uf => uf.Product)
            //    .WithMany(f => f.UserFavorites);
        }
    }
}
