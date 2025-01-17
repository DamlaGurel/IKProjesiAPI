﻿using IKProjesiAPI.Application.Extensions;
using IKProjesiAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs
{
    public class CreateSiteManagerDto
    {
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string Password { get; set; }
        public Department? DepartmentName { get; set; }
        public int? DepartmentId { get; set; }
        public string? UserName { get; set; }
        public string PersonalEmail { get; set; }
        public string? ImageString { get; set; }
        public byte[]? ImageBytes { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? IdentityNumber { get; set; }
        public DateTime? StartDateOfWork { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }

        public DateTime CreatedDate => DateTime.Now;
        public Status Status => Status.Active;

    }
}
