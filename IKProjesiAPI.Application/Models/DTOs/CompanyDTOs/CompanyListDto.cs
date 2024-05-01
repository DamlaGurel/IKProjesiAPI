
namespace IKProjesiAPI.Application.Models.DTOs.CompanyDTOs
{
    public class CompanyListDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyTitle { get; set; }
        public string CompanyTaxOffice { get; set; }
        public string LogoString { get; set; }
        public byte[]? LogoBytes { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }       
    }
}
