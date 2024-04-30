using IKProjesiAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs
{
    public class SummaryCompanyManagerDto
    {
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }

        public string? LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string? Email { get; set; }
        public Job? JobName { get; set; }
        public Department? DepartmentName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }

        public string? ImageString { get; set; }
        public byte[]? ImageBytes { get; set; }
    }
}
