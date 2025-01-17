﻿using IKProjesiAPI.Domain.Enums;


namespace IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs
{
    public class CreateCompanyManagerDto
    {    
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? SecondLastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? IdentityNumber { get; set; }
        public string PersonalEmail { get; set; }
        public DateTime? StartDateOfWork { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedDate => DateTime.Now;
        public Status Status => Status.Active;
        public string? ImageString { get; set; }
        public byte[]? ImageBytes { get; set; }
        public double? Payment { get; set; }

        public string? UserName { get; set; }

    }
}

