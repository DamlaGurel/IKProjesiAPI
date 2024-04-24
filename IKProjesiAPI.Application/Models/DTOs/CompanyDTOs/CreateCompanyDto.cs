using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace IKProjesiAPI.Application.Models.DTOs.CompanyDTOs
{
    public class CreateCompanyDto
    {
        public string CompanyName { get; set; }
        public string CompanyTitle { get; set; }
        public string MersisNumber { get; set; }
        public string CompanyTaxNumber { get; set; }
        public string CompanyTaxOffice { get; set; }
        //[NotMapped]
        //public IFormFile? Logo { get; set; }
        //public string LogoPath { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int EmployeeNumber { get; set; }
        public DateTime FoundationYear { get; set; }
        public DateTime StartContractDate { get; set; }
        public DateTime EndContractDate { get; set; }
        public DateTime CreatedDate => DateTime.Now;

        //public Status Status => Status.Active;

       // public List<ListCompanyManagerDto>? CompanyManagers { get; set; }
    }
}
