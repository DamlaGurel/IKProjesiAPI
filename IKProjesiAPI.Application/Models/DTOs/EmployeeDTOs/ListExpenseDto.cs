using System;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs
{
	public class ListExpenseDto
	{
        public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? ExpenseType { get; set; }
        public double? TotalExpense { get; set; }
        public int? MoneyType { get; set; }
        public int? ApprovalType { get; set; }
        public DateTime? ResponseDate { get; set; }
        public DateTime? RequestDate { get; set; }

    }
}

