﻿
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs
{
    public class CreateExpenseDto
    {
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public ExpenseType? ExpenseType { get; set; }
        public double? TotalExpense { get; set; }
        public MoneyType? MoneyType { get; set; }
        public ApprovalType? ApprovalType { get; set; }
        public DateTime? ResponseDate { get; set; }
        public DateTime? RequestDate { get; set; }
        //public string dosyaeklemepropu { get; set; }
    }
}
