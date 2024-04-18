using IKProjesiAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Infrastructure.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public AppDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:gadi.database.windows.net,1433;Initial Catalog=Gadi;Persist Security Info=False;User ID=gadi;Password=bilgeadam123**;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;");
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<SiteManager> SiteManagers { get; set; }
        public DbSet<CompanyManager> CompanyManagers { get; set; }

    }
}
