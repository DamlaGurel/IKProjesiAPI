using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Application.Models.DTOs.CompanyDTOs
{
    public class CreateCompanyDto
    {
        public string CompanyName { get; set; }
        public string CompanyTitle { get; set; }
        public string MersisNumber { get; set; }
        public string CompanyTaxNumber { get; set; }
        public string CompanyTaxOffice { get; set; }
        public string LogoString { get; set; }
        public byte[]? LogoByte { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int EmployeeNumber { get; set; }
        public DateTime FoundationYear { get; set; }
        public DateTime StartContractDate { get; set; }
        public DateTime EndContractDate { get; set; }
        public DateTime CreatedDate => DateTime.Now;
        public Status Status => Status.Active;

       // public List<ListCompanyManagerDto>? CompanyManagers { get; set; }
    }
}
