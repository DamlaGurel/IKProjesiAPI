using IKProjesiAPI.Domain.Entities.AppEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Domain.Entities
{
    public class TemporaryPassword
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
