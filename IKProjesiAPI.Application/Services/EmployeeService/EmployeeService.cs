using System.ComponentModel.Design;
using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Repositories;

namespace IKProjesiAPI.Application.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo _employeeRepo;
        private readonly IExpenseRepo _expenseRepo;
        private readonly ITakeOffDayRepo _takeOffDayRepo;
        private readonly IAdvancePaymentRepo _advancePaymentRepo;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepo employeeRepo, IMapper mapper, IExpenseRepo expenseRepo, ITakeOffDayRepo takeOffDayRepo, IAdvancePaymentRepo advancePaymentRepo)
        {
            _employeeRepo = employeeRepo;
            _mapper = mapper;
            _expenseRepo = expenseRepo;
            _takeOffDayRepo = takeOffDayRepo;
            _advancePaymentRepo = advancePaymentRepo;
        }

        public async Task<CreateEmployeeDto> CreateEmployee(CreateEmployeeDto model)
        {
            var employee = _mapper.Map<Employee>(model);

            employee.Email = $"{employee.FirstName}.{employee.LastName}@bilgeadamboost.com";
            employee.UserName = employee.Email;
            employee.NormalizedUserName = employee.Email.ToUpper();
            employee.JobName = Job.Employee;

            await _employeeRepo.Create(employee);
            return _mapper.Map<CreateEmployeeDto>(employee);
        }


        // Expence işlemleri 

        public async Task CreateExpense(CreateExpenseDto model)
        {
            var employeeExpense = _mapper.Map<Expense>(model);

            employeeExpense.ApprovalType = ApprovalType.Waiting;
            employeeExpense.RequestDate = DateTime.Now;

            await _expenseRepo.Create(employeeExpense);
        }


        //İzin İşlemleri

        public async Task CreateTakeDayOff(CreateTakeDayOffDto model)
        {
            var dayOff = _mapper.Map<TakeOffDay>(model);

            dayOff.ApprovalType = ApprovalType.Waiting;
            dayOff.RequestTime = DateTime.Now;

            // Günler arasındaki farkı hesaplayın
            int numberOfDays = (int)(model.DayOffEndTime - model.DayOffStartTime).TotalDays;

            // Toplam gün sayısını ayarlayın
            dayOff.DayNumber = numberOfDays;

            await _takeOffDayRepo.Create(dayOff);
        }

        public async Task<int> CalculateAnnualOffDay(DateTime startDateOfWork)
        {
            DateTime today = DateTime.Today;

            TimeSpan workingDuration = today - startDateOfWork;

            int yearsWorked = (int)(workingDuration.Days / 365.25);

            int annualOffDays = 0;

            if (yearsWorked >= 1 && yearsWorked < 5)
            {
                annualOffDays = 14;
            }
            else if (yearsWorked >= 5 && yearsWorked < 10)
            {
                annualOffDays = 21;
            }
            else if (yearsWorked >= 10)
            {
                annualOffDays = 30;
            }
            return annualOffDays;
        }

        public async Task UpdateTakeDayOff(UpdateDayOffDto model)
        {
            model.ResponseTime = DateTime.Now;

            model.ApprovalType.Equals(ApprovalType)
            
            var dayOff = await _takeOffDayRepo.GetDefault(x => x.Id == model.Id);

            _mapper.Map<UpdateDayOffDto>(model)

            


           await _takeOffDayRepo.Update(dayOff);


           


        }

        public async Task<List<ListOffDaysDto>> ListTakeDayOff(int id)
        {

            var listTakeDayOff = await _takeOffDayRepo.GetFilteredList(select: x => _mapper.Map<ListOffDaysDto>(x), where: x => x.EmployeeId.Equals(id));


            return listTakeDayOff;

        }

        public async Task<UpdateDayOffDto> GetTakeDayOff(int id)
        {
            var takeDayOff = await _takeOffDayRepo.GetDefault(x => x.Id == id);

            return _mapper.Map<UpdateDayOffDto>(takeDayOff);


        }


    }
}
