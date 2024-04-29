﻿using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Domain.Entities
{
    public class TemporaryPassword
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
        public AppUser AppUser { get; set; }
        //public DateTime? CreatedDate { get ; set; }
        //public DateTime? UpdatedDate { get; set; }
        //public DateTime? DeletedDate { get; set; }
        //public Status? Status { get; set; }
    }
}
