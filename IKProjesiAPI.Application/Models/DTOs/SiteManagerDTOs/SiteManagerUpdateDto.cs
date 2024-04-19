using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs
{
    public class SiteManagerUpdateDto
    {
        public int Id { get; set; }
        public string? ImagePath { get; set; }
        [NotMapped]
        public IFormFile ProfilePicture { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
