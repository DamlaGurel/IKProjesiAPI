﻿using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Domain.Entities
{
	public class Expense : IBaseEmployee
	{
        public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public ExpenseType? ExpenseType { get; set; }
        public double? TotalExpense { get; set; }
        public MoneyType? MoneyType { get; set; }
        public ApprovalType? ApprovalType { get; set; }
        public DateTime? ResponseDate { get; set; }
        public DateTime? RequestDate { get; set; }
        public byte[]? FileByteArray { get; set; }

    }
}

