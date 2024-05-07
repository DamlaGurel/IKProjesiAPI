
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace IKProjesiAPI.Application.Models.DTOs.ExpenseDTOs
{
    public class CreateExpenseDto
    {
        public int ExpenseTypeId { get; set; }
        public double? TotalExpense { get; set; }
        public int MoneyTypeId { get; set; }
        public byte[]? FileByteArray { get; set; }

    }
}
