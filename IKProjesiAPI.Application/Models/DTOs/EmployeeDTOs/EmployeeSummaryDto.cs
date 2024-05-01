using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Application.Models.DTOs.PersonelDTOs
{
    public class EmployeeSummaryDto
    {
        //Foto, Ad, Soyad, Email, Telefon, Adres,Meslek, Departman

        public string? LogoString { get; set; }
        public byte[]? LogoBytes { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public Job? JobName { get; set; }
        public Department? DepartmentName { get; set; }

    }
}
