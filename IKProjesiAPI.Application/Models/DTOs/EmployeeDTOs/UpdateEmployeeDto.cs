using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs
{
    public class UpdateEmployeeDto
    {
        //(Foto, Adres, Telefon)

        public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string? SecondName { get; set; }
        //public string LastName { get; set; }
        //public string? SecondLastName { get; set; }
        public string? ImageString { get; set; }
        public byte[]? ImageBytes { get; set; }
        //public DateTime BirthDate { get; set; }
        //public string? BirthPlace { get; set; }
        //public string? IdentityNumber { get; set; }
        //public DateTime StartDateOfWork { get; set; }
        //public DateTime? FinishDateOfWork { get; set; }
        //public Status Status { get; set; }
        //public Job JobName { get; set; }
        //public Department DepartmentName { get; set; }
        ////public Company CompanyName { get; set; }
        //public string Email { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
