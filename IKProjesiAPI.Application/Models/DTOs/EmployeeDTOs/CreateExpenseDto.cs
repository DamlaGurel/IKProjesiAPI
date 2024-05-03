
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs
{
    public class CreateExpenseDto
    {
        public int ExpenseTypeId { get; set; }
        //public ExpenseType? ExpenseType { get; set; }
        public double? TotalExpense { get; set; }
        //public MoneyType? MoneyType { get; set; }
        public int MoneyTypeId { get; set; }
        //public IFormFile? File { get; set; }
    }
}
