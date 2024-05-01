using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;

namespace IKProjesiAPI.Application.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<CreateEmployeeDto> CreateEmployee(CreateEmployeeDto model);
        Task CreateExpense(CreateExpenseDto model);
    }
}
