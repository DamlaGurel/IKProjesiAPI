using System;
namespace IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs
{
	public class ApprovalForAdvanceDto
	{
        public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? AdvanceType { get; set; }
        public double? TotalAdvance { get; set; }
        public int? MoneyType { get; set; }
        public int? ApprovalType { get; set; }
        public DateTime? ResponseTime { get; set; }
        public DateTime? RequestDate { get; set; }
        public string? Description { get; set; }
        public string? EmployeeFullName { get; set; }

    }
}

