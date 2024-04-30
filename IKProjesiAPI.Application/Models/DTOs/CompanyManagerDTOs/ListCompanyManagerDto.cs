using System;
using IKProjesiAPI.Application.Extensions;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs
{
    public class ListCompanyManagerDto
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        public string? ImageString { get; set; }
        public byte[]? ImageBytes { get; set; }
    }
}

