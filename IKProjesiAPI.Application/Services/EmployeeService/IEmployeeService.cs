using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;

namespace IKProjesiAPI.Application.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<CreateEmployeeDto> CreateEmployee(CreateEmployeeDto model);
        Task<EmployeeSummaryDto> GetEmployeeSummary(int id);
        Task<DetailEmployeeDto> GetEmployeeDetails(int id);
        Task CreateExpense(CreateExpenseDto model);
    }
}
