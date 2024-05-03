using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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

        public async Task CreateAdvancePayment(CreateAdvancePaymentDto model)
        {
            var employee = _mapper.Map<AdvancePayment>(model);
            employee.EmployeeId = model.EmployeeId;
            employee.ApprovalType = ApprovalType.Waiting;
            employee.RequestDate = DateTime.Now;
            employee.AdvanceType = model.AdvanceType;
            //employee.TotalAdvance = employee.Payment * 3;

            await _advancePaymentRepo.Create(employee); 

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

            string imageString = null;

            if (employee != null && employee.ImageBytes != null)
            {
                imageString = Convert.ToBase64String(employee.ImageBytes);
            }

            employee.ImageString = imageString;

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
        // Expence işlemleri 

        public async Task CreateExpense(CreateExpenseDto model)
        {
            var employeeExpense = _mapper.Map<Expense>(model);

            //if (model.File is not null)
            //{
            //    using (var memoryStream = new MemoryStream())
            //    {
            //        await model.File.CopyToAsync(memoryStream);

            //        if (memoryStream.Length < 2097152)
            //            employeeExpense.FileByteArray = memoryStream.ToArray();
            //    }
            //}
            employeeExpense.ExpenseType = ConvertNumberToExpenseType(model.ExpenseTypeId);
            employeeExpense.MoneyType = ConvertNumberToMoneyType(model.MoneyTypeId);
            employeeExpense.ApprovalType = ApprovalType.Waiting;
            employeeExpense.RequestDate = DateTime.Now;

            await _expenseRepo.Create(employeeExpense);
        }

        private static ExpenseType ConvertNumberToExpenseType(int number)
        {
            return number switch
            {
                1 => ExpenseType.Transportation,
                2 => ExpenseType.Accommodation,
                3 => ExpenseType.Food,
                4 => ExpenseType.Other,
                _ => throw new ArgumentException("Geçersiz sayısal değer"),
            };
        }

        private static MoneyType ConvertNumberToMoneyType(int number)
        {
            return number switch
            {
                1 => MoneyType.TRY,
                2 => MoneyType.USD,
                3 => MoneyType.EUR,
                4 => MoneyType.GBP,
                5 => MoneyType.JPY,
                6 => MoneyType.CHF,
                7 => MoneyType.AUD,
                8 => MoneyType.CAD,
                9 => MoneyType.NZD,
                10 => MoneyType.CNY,
                11 => MoneyType.BRL,
                _ => throw new ArgumentException("Geçersiz sayısal değer"),
            };
        }

    }
}
