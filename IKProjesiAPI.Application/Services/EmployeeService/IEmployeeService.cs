using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;

namespace IKProjesiAPI.Application.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<CreateEmployeeDto> CreateEmployee(CreateEmployeeDto model);
        Task CreateExpense(CreateExpenseDto model);

        Task CreateTakeDayOff(CreateTakeDayOffDto model);

        Task<int> CalculateAnnualOffDay(DateTime startDateOfWork);
        Task UpdateTakeDayOff(UpdateDayOffDto model);
        Task<List<ListOffDaysDto>> ListTakeDayOff(int id);

        Task<UpdateDayOffDto> GetTakeDayOff(int id);


    }
}
