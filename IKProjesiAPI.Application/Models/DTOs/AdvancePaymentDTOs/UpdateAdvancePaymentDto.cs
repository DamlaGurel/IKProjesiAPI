using System;
using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Application.Models.DTOs.AdvancePaymentDTOs
{
	public class UpdateAdvancePaymentDto
	{
        public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public int AdvanceTypeId { get; set; }
        public double? TotalAdvance { get; set; }
        //public double? Payment { get; set; }
        public int MoneyTypeId { get; set; }
        public int? ApprovalType { get; set; }
        public DateTime? ResponseTime { get; set; }
        public DateTime? RequestDate { get; set; }
        public string? Description { get; set; }
        public string? EmployeeFullName { get; set; }
    }
}

