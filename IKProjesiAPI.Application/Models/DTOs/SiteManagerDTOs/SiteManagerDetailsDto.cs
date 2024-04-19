using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs
{
    public class SiteManagerDetailsDto
    {
        public string FirstName { get; set; }
        public string? SecondName { get; set; }

        public string LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string Password { get; set; }
        public string? ImagePath { get; set; }
        [NotMapped]
        public IFormFile ProfilePicture { get; set; }
        public DateTime BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? IdentityNumber { get; set; }
        public DateTime StartDateOfWork { get; set; }
<<<<<<< HEAD:IKProjesiAPI.Domain/Entities/AppUser.cs
        public DateTime FinishDateOfWork { get; set; }


        public DateTime HiredDate { get; set; } 
=======
        public DateTime? FinishDateOfWork { get; set; }
>>>>>>> origin/master:IKProjesiAPI.Application/Models/DTOs/SiteManagerDTOs/SiteManagerDetailsDto.cs
        public Job JobName { get; set; }
        public Department DepartmentName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
