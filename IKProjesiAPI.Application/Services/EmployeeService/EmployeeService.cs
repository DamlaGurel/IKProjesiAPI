using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using IKProjesiAPI.Domain.Repositories;

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
            employee.AdvanceType = model.AdvanceType;
            employee.ApprovalType = ApprovalType.Waiting;
            employee.RequestDate = DateTime.Now;
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
            
            if (model.ImageString is not null)
            {
                employee.ImageBytes = Convert.FromBase64String(model.ImageString);
                            
            }
            
            //employee.CompanyManager=_

            if (model.DepartmentNumber is not null)
            {
                employee.DepartmentName = (Department)model.DepartmentNumber;                
            }

            employee.CreatedDate = DateTime.Now;
            employee.Status = Status.Active;
            employee.Password = $"{employee.FirstName}.{employee.LastName}";

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

            if (model.ImageString is not null)
            {
                employee.ImageBytes = Convert.FromBase64String(model.ImageString);
            }

           
            employee.Status = Status.Modified;
            employee.UpdatedDate = DateTime.Now;


            await _employeeRepo.Update(employee);
        }

        public async Task CreateExpense(CreateExpenseDto model)
        {
            var employeeExpense = _mapper.Map<Expense>(model);

            employeeExpense.ExpenseType = (ExpenseType)model.ExpenseTypeId;
            employeeExpense.MoneyType = (MoneyType)model.MoneyTypeId;

            employeeExpense.ApprovalType = ApprovalType.Waiting;
            employeeExpense.RequestDate = DateTime.Now;

            await _expenseRepo.Create(employeeExpense);
        }
    }
}
