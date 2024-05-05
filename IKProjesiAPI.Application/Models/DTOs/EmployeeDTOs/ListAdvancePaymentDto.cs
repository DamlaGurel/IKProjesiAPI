using IKProjesiAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs
{
    public class ListAdvancePaymentDto
    {
        public AdvanceType AdvanceType { get; set; }
        public double? TotalAdvance { get; set; }
        public MoneyType MoneyType { get; set; }
        public ApprovalType ApprovalType { get; set; }
    }
}
