﻿using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Models.DTOs.AdvancePaymentDTOs
{
    public class CreateAdvancePaymentDto
    {
        //public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public int AdvanceTypeId { get; set; }
        public double? TotalAdvance { get; set; }
        public double? Payment { get; set; }
        public int MoneyTypeId { get; set; }
        public ApprovalType? ApprovalType { get; set; }
        public DateTime? ResponseTime { get; set; }
        public DateTime? RequestDate { get; set; }
        public string? Description { get; set; }
    }
}
