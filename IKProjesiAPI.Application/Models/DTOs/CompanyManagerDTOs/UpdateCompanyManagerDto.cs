using System.ComponentModel.DataAnnotations;

namespace IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs
{
	public class UpdateCompanyManagerDto
	{
        public int Id { get; set; }

        [Display(Name = "Adres")]
        public string? Address { get; set; }

        [Display(Name = "Telefon Numarası")]
        public string? PhoneNumber { get; set; }

        public string? ImageString { get; set; }
        public byte[]? ImageBytes { get; set; }
    }
}

