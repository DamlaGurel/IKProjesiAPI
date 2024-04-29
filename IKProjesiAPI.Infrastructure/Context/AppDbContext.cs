using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Infrastructure.EntityTypeConfig;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Infrastructure.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:gadi.database.windows.net,1433;Initial Catalog=Gadi;Persist Security Info=False;User ID=gadi;Password=bilgeadam123**;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;");
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<SiteManager> SiteManagers { get; set; }
        public DbSet<CompanyManager> CompanyManagers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<TemporaryPassword> TemporaryPassword { get; set; }
        public DbSet<Personel> Personels { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserConfig())
                    .ApplyConfiguration(new AppRoleConfig())
                    .ApplyConfiguration(new AppUserRoleConfig())
                    .ApplyConfiguration(new AppCompanyConfig());


            builder.Entity<TemporaryPassword>().Property(t => t.Id).UseIdentityColumn().ValueGeneratedOnAdd();

            //builder.Entity<AppUser>(b =>
            //{
            //    // Primary key
            //    b.HasKey(u => u.Id);


            //    // Maps to the AspNetUsers table
            //    b.ToTable("AspNetUsers");

            //});

            //builder.Entity<CompanyManager>().ToTable("CompanyManager");
            //builder.Entity<SiteManager>().ToTable("SiteManager");



            base.OnModelCreating(builder);
        }

    }
}
