using IKProjesiAPI.Application.Models.DTOs.AdvancePaymentDTOs;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Application.Models.DTOs.ExpenseDTOs;
using IKProjesiAPI.Application.Models.DTOs.OffDayDTOs;
using IKProjesiAPI.Domain.Entities;

namespace IKProjesiAPI.Application.Services.EmployeeService
{
    public interface IEmployeeService
    {
        #region Employee
        Task<CreateEmployeeDto> CreateEmployee(CreateEmployeeDto model);
        Task<EmployeeSummaryDto> GetEmployeeSummary(int id);
        Task<DetailEmployeeDto> GetEmployeeDetails(int id);
        //Task UpdateEmployee(UpdateEmployeeDto model);
        Task<Employee> UpdateEmployee(UpdateEmployeeDto model);
        Task<UpdateEmployeeDto> GetEmployeeById(int id);
        #endregion

        #region Expense
        Task CreateExpense(CreateExpenseDto model);
        Task UpdateExpense(UpdateExpenseDto model);
        Task<List<ListExpenseDto>> ListExpense(int id);
        Task<UpdateExpenseDto> GetExpense(int id);
        #endregion

        #region Off Day
        Task CreateOffDay(CreateOffDayDto model);
        Task<int> CalculateAnnualOffDay(DateTime startDateOfWork);
        Task UpdateOffDay(UpdateOffDayDto model);
        Task<List<ListOffDayDto>> ListOffDay(int id);
        Task<UpdateOffDayDto> GetOffDay(int id);
        #endregion

        #region Advance Payment
        Task CreateAdvancePayment(CreateAdvancePaymentDto model);
        Task UpdateAdvancePayment(UpdateAdvancePaymentDto model);
        Task<UpdateAdvancePaymentDto> GetAdvancePayment(int id);
        Task<List<ListAdvancePaymentDto>> ListAdvancePayment(int id);
        #endregion
    }
}
