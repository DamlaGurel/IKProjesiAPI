using System;
using System.ComponentModel.DataAnnotations;
using IKProjesiAPI.Application.Extensions;
using IKProjesiAPI.Application.Models.DTOs.CompanyDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs
{
    public class CreateCompanyManagerDto
    {
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? IdentityNumber { get; set; }
        public DateTime? StartDateOfWork { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CompanyName { get; set; }
        public Job? JobName { get; set; }
        public Department? DepartmentName { get; set; }
        public DateTime CreatedDate => DateTime.Now;
        public Status Status => Status.Active;
        // public Status Status { get; set; }

        // //Company Seçim 
        // public int? CompanyId { get; set; }

        //public List<CompanyListDto>? Companies { get; set; } //burada list içerisine vm dto companyden alınıp koyulca!!


    }
}

