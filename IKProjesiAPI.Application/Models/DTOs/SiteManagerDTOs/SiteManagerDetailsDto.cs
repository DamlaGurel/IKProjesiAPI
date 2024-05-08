using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs
{
    public class SiteManagerDetailsDto
    {
        public string FirstName { get; set; }
        public string? SecondName { get; set; }

        public string LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string Password { get; set; }
        public string? ImageString { get; set; }
        public byte[]? ImageBytes { get; set; }
        public DateTime BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? IdentityNumber { get; set; }
        public DateTime StartDateOfWork { get; set; }
        public DateTime? FinishDateOfWork { get; set; }
        public Job JobName { get; set; }
        public Department DepartmentName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
