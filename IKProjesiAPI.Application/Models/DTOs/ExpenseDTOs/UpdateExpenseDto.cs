using System;
namespace IKProjesiAPI.Application.Models.DTOs.ExpenseDTOs
{
	public class UpdateExpenseDto
	{
        public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? ExpenseType { get; set; }
        public double? TotalExpense { get; set; }
        public int? MoneyType { get; set; }
        public int? ApprovalType { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string? EmployeeFullName { get; set; }
    }
}

