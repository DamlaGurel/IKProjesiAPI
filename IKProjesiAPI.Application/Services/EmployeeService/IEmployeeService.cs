using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Domain.Entities;

namespace IKProjesiAPI.Application.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<CreateEmployeeDto> CreateEmployee(CreateEmployeeDto model);
        Task<EmployeeSummaryDto> GetEmployeeSummary(int id);
        Task<DetailEmployeeDto> GetEmployeeDetails(int id);
        //Task UpdateEmployee(UpdateEmployeeDto model);
        Task<Employee> UpdateEmployee(UpdateEmployeeDto model);
        Task<UpdateEmployeeDto> GetEmployeeById(int id);
        Task CreateExpense(CreateExpenseDto model);
        Task CreateAdvancePayment(CreateAdvancePaymentDto model);
    }
}
