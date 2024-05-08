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
        public string? ImageString { get; set; }
        public byte[]? ImageBytes { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
