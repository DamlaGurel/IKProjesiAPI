﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace IKProjesiAPI.Application.Models.DTOs.CompanyDTOs
{
    public class AddCompanyDto
    {
        public string CompanyName { get; set; }
        public string CompanyTitle { get; set; }
        public string MersisNumber { get; set; }
        public string CompanyTaxNumber { get; set; }
        public string CompanyTaxOffice { get; set; }
        public IFormFile Logo { get; set; }
        public string LogoPath { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int EmployeeNumber { get; set; }
        public DateTime FoundationYear { get; set; }
        public DateTime StartContractDate { get; set; }
        public DateTime EndContractDate { get; set; }

        public List<CompanyManager> CompanyManagers { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status Status { get; set; }
    }
}
