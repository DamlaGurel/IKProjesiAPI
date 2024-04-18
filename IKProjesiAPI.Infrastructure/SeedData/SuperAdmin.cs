using IKProjesiAPI.Application.Models.DTOs;
using IKProjesiAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Infrastructure.SeedData
{
    public static class SuperAdmin
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiteManager>().HasData(
                new SiteManager
                {

                });
        }
    }
}
