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
    public class SiteManagerSummaryDto
    {
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }

        public string? LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string? ImagePath { get; set; }
        public string? Email { get; set; }
        public Job? JobName { get; set; }
        public Department? DepartmentName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
