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
        //Employee 
        Task<CreateEmployeeDto> CreateEmployee(CreateEmployeeDto model);
        Task<EmployeeSummaryDto> GetEmployeeSummary(int id);
        Task<DetailEmployeeDto> GetEmployeeDetails(int id);
        //Task UpdateEmployee(UpdateEmployeeDto model);
        Task<Employee> UpdateEmployee(UpdateEmployeeDto model);
        Task<UpdateEmployeeDto> GetEmployeeById(int id);

        //Expense
        Task CreateExpense(CreateExpenseDto model);
        Task UpdateExpense(UpdateExpenseDto model);
        Task<List<ListExpenseDto>> ListExpense(int id);
        Task<UpdateExpenseDto> GetExpense(int id);

        //DayOff
        Task CreateOffDay(CreateOffDayDto model);
        Task<int> CalculateAnnualOffDay(DateTime startDateOfWork);
        Task UpdateOffDay(UpdateOffDayDto model);
        Task<List<ListOffDayDto>> ListOffDay(int id);
        Task<UpdateOffDayDto> GetOffDay(int id);

        //AdvancePayment
        Task CreateAdvancePayment(CreateAdvancePaymentDto model);
        Task<List<ListAdvancePaymentDto>> ListAdvancePayments();
        Task UpdateAdvancePayment(UpdateAdvancePaymentDto model);
        Task<List<ListAdvancePaymentDto>> ListAdvancePayment(int id);
        Task<UpdateAdvancePaymentDto> GetAdvancePayment(int id);
    }
}
