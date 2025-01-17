﻿using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Infrastructure.EntityTypeConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<AdvancePayment> AdvancePayments { get; set; }
        public DbSet<TakeOffDay> TakeOffDays { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserConfig())
                    .ApplyConfiguration(new AppRoleConfig())
                    .ApplyConfiguration(new AppUserRoleConfig())
                    .ApplyConfiguration(new AppCompanyConfig())
                    .ApplyConfiguration(new AdvancePaymentConfig())
                    .ApplyConfiguration(new CompanyManagerConfig())
                    .ApplyConfiguration(new ExpenseConfig())
                    .ApplyConfiguration(new EmployeeConfig())
                    .ApplyConfiguration(new SiteManagerConfig())
                    .ApplyConfiguration(new TakeOffDayConfig());


            //builder.Entity<TemporaryPassword>().HasKey(t => t.Id);
            //builder.Entity<TemporaryPassword>().Property(t => t.Id).ValueGeneratedOnAdd();

            base.OnModelCreating(builder);
        }

    }
}
