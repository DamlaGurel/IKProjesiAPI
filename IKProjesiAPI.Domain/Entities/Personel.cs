using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Domain.Entities
{
    public class Personel:AppUser
    {
        public string? UserName { get; set; }
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
