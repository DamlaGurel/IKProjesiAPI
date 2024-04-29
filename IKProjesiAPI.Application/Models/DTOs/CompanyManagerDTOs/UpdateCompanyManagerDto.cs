using System;
using IKProjesiAPI.Application.Extensions;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs
{
	public class UpdateCompanyManagerDto
	{
        public int Id { get; set; }

        [Display(Name = "Adres")]
        public string? Address { get; set; }

        [Display(Name = "Telefon Numarası")]
        public string? PhoneNumber { get; set; }

        public string? ImageString { get; set; }
        public byte[]? ImageBytes { get; set; }
    }
}

