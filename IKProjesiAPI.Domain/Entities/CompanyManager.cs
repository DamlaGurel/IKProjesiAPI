using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Domain.Entities
{
    public class CompanyManager:AppUser
    {
        public CompanyManager()
        {
            Employees = new List<Employee>();
        }
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public double? Payment { get; set; }

    }
}
