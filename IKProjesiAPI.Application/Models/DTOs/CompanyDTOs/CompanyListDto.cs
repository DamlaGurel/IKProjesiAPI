using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Models.DTOs.CompanyDTOs
{
    public class CompanyListDto
    {
        //Logo,Ad,Unvan,Email,Telefon)
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyTitle { get; set; }      
        //[NotMapped]
        //public IFormFile Logo { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }       
    }
}
