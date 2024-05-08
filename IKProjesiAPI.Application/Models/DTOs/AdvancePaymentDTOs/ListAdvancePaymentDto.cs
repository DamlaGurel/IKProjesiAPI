using System;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Application.Models.DTOs.AdvancePaymentDTOs
{
    public class ListAdvancePaymentDto
	{
        public AdvanceType AdvanceType { get; set; }
        public double? TotalAdvance { get; set; }
        public MoneyType MoneyType { get; set; }
        public ApprovalType ApprovalType { get; set; }
    }
}

