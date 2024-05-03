using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs
{
    public class CreateAdvancePaymentDto
    {
        //public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public AdvanceType? AdvanceType { get; set; }
        public double? TotalAdvance { get; set; }
        //public double? Payment { get; set; }
        public MoneyType? MoneyType { get; set; }
        public ApprovalType? ApprovalType { get; set; }
        public DateTime? ResponseTime { get; set; }
        public DateTime? RequestDate { get; set; }
        public string? Description { get; set; }
    }
}
