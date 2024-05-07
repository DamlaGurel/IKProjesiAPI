using System.ComponentModel.Design;
using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.AdvancePaymentDTOs;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Application.Models.DTOs.ExpenseDTOs;
using IKProjesiAPI.Application.Models.DTOs.OffDayDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
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
        private readonly ICompanyManagerRepo _companyManagerRepo;
        public EmployeeService(IEmployeeRepo employeeRepo, IMapper mapper, IExpenseRepo expenseRepo, ITakeOffDayRepo takeOffDayRepo, IAdvancePaymentRepo advancePaymentRepo, ICompanyManagerRepo companyManagerRepo)
        {
            _employeeRepo = employeeRepo;
            _mapper = mapper;
            _expenseRepo = expenseRepo;
            _takeOffDayRepo = takeOffDayRepo;
            _advancePaymentRepo = advancePaymentRepo;
            _companyManagerRepo = companyManagerRepo;
        }

        

        public async Task<CreateEmployeeDto> CreateEmployee(CreateEmployeeDto model)
        {
            var employee = _mapper.Map<Employee>(model);

            employee.Email = $"{employee.FirstName}.{employee.LastName}@bilgeadamboost.com";
            employee.UserName = employee.Email;
            employee.NormalizedUserName = employee.Email.ToUpper();
            employee.JobName = Job.Employee;
            employee.ImageBytes = Convert.FromBase64String(model.ImageString);
            //employee.CompanyManager=_
            employee.DepartmentName = model.DepartmentName;
            employee.CreatedDate = DateTime.Now;
            employee.Status = Status.Active;
            employee.Password = "123123";

            await _employeeRepo.Create(employee);
            return _mapper.Map<CreateEmployeeDto>(employee);
        }

        public async Task<EmployeeSummaryDto> GetEmployeeSummary(int id)
        {
            var employee = await _employeeRepo.GetFilteredFirstOrDefault(select: x => _mapper.Map<EmployeeSummaryDto>(x),
                                                                                     where: x => x.Id == id);
            return employee;
        }

        public async Task<DetailEmployeeDto> GetEmployeeDetails(int id)
        {
            var employee = await _employeeRepo.GetFilteredFirstOrDefault(select: x => _mapper.Map<DetailEmployeeDto>(x),
                                                                                     where: s => s.Id.Equals(id) && s.Status != Status.Pasive);

            if (employee != null && employee.ImageBytes != null)
                employee.ImageString = Convert.ToBase64String(employee.ImageBytes);

            return employee;
        }

        public async Task<UpdateEmployeeDto> GetEmployeeById(int id)
        {
            var employee = await _employeeRepo.GetFilteredFirstOrDefault(select: x => _mapper.Map<UpdateEmployeeDto>(x),
                                                                                     where: x => x.Id == id);
            return employee;
        }

        public async Task UpdateEmployee(UpdateEmployeeDto model)
        {
            var employee = await _employeeRepo.GetDefault(x => x.Id == model.Id);

            employee.Address = model.Address;
            employee.PhoneNumber = model.PhoneNumber;
            //employee.ImageBytes = model.ImageBytes;
            employee.ImageBytes = Convert.FromBase64String(model.ImageString);
            employee.Status = Status.Modified;
            employee.UpdatedDate = DateTime.Now;


            await _employeeRepo.Update(employee);
        }


        //Expense İşlemleri
        public async Task CreateExpense(CreateExpenseDto model)
        {
            var employeeExpense = _mapper.Map<Expense>(model);

            employeeExpense.ExpenseType = (ExpenseType)model.ExpenseTypeId;
            employeeExpense.MoneyType = (MoneyType)model.MoneyTypeId;

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

            int numberOfDays = (int)(model.DayOffEndTime - model.DayOffStartTime).TotalDays;

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
            var dayOff = _mapper.Map<TakeOffDay>(model);


            dayOff.ResponseTime = DateTime.Now;

           dayOff.ApprovalType= (ApprovalType)model.ApprovalType;
            


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
        //Advance Payment İşlemleri
        public async Task CreateAdvancePayment(CreateAdvancePaymentDto model)
        {
            var employee = _mapper.Map<AdvancePayment>(model);

            employee.EmployeeId = model.EmployeeId;
            employee.AdvanceType = model.AdvanceType;
            employee.ApprovalType = ApprovalType.Waiting;
            employee.RequestDate = DateTime.Now;
            //employee.TotalAdvance = employee.Payment * 3;

            await _advancePaymentRepo.Create(employee);

        }

    }
}
