using IKProjesiAPI.Application.Models.DTOs.AdvancePaymentDTOs;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Application.Models.DTOs.ExpenseDTOs;
using IKProjesiAPI.Application.Models.DTOs.OffDayDTOs;

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

        //DayOff
        Task CreateTakeDayOff(CreateTakeDayOffDto model);
        Task<int> CalculateAnnualOffDay(DateTime startDateOfWork);
        Task UpdateTakeDayOff(UpdateDayOffDto model);
        Task<List<ListOffDaysDto>> ListTakeDayOff(int id);
        Task<UpdateDayOffDto> GetTakeDayOff(int id);

        //AdvancePayment
        Task CreateAdvancePayment(CreateAdvancePaymentDto model);
        Task<List<ListAdvancePaymentDto>> ListAdvancePayments(); 
    }
}
