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
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        public double? Payment { get; set; }

    }
}
