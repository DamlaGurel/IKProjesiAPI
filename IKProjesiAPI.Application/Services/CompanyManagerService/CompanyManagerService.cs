using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.AdvancePaymentDTOs;
using IKProjesiAPI.Application.Models.DTOs.ExpenseDTOs;
using IKProjesiAPI.Application.Models.DTOs.OffDayDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using IKProjesiAPI.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using IKProjesiAPI.Infrastructure.Repositories;

namespace IKProjesiAPI.Application.Services.CompanyManagerService
{
    public class CompanyManagerService : ICompanyManagerService
    {
        private readonly IAppUserRepo _appUserRepo;
        private readonly ICompanyManagerRepo _companyManagerRepo;
        private readonly ICompanyRepo _companyRepo;
        private readonly IMapper _mapper;
        private readonly ITakeOffDayRepo _takeOffDayRepo;
        private readonly IExpenseRepo _expenseRepo;
        private readonly IAdvancePaymentRepo _advancePaymentRepo;
        private readonly IEmployeeRepo _employeeRepo;

        public CompanyManagerService(ICompanyManagerRepo companyManagerRepo, ICompanyRepo companyRepo, IMapper mapper, ITakeOffDayRepo takeOffDayRepo, IExpenseRepo expenseRepo, IAdvancePaymentRepo advancePaymentRepo, IAppUserRepo appUserRepo, IEmployeeRepo employeeRepo)
        {
            _companyRepo = companyRepo;
            _companyManagerRepo = companyManagerRepo;
            _mapper = mapper;
            _takeOffDayRepo = takeOffDayRepo;
            _expenseRepo = expenseRepo;
            _advancePaymentRepo = advancePaymentRepo;
            _appUserRepo = appUserRepo;
            _employeeRepo = employeeRepo;
        }

        #region Company Manager
        public async Task<CreateCompanyManagerDto> Create(CreateCompanyManagerDto model)
        {
            var email = await _appUserRepo.GenerateUniqueEmail(model.FirstName, model.LastName);
            var companyManager = _mapper.Map<CompanyManager>(model);

            companyManager.Email = email;
            companyManager.UserName = companyManager.Email;
            companyManager.NormalizedUserName = companyManager.Email.ToUpper();
            companyManager.Password = $"{model.FirstName}.{model.LastName}";


            Company company = await _companyRepo.GetDefault(c => c.Id == model.CompanyId);
            companyManager.Company = company;
            companyManager.JobName = Job.COMPANYMANAGER;
            companyManager.ImageBytes = Convert.FromBase64String(model.ImageString);
            companyManager.CreatedDate = DateTime.Now;
            companyManager.Status = Status.Active;

            await _companyManagerRepo.Create(companyManager);
            return _mapper.Map<CreateCompanyManagerDto>(companyManager);
        }

        public async Task Delete(int id)
        {
            var companyManager = await _companyManagerRepo.GetDefault(x => x.Id.Equals(id));
            await _companyManagerRepo.Delete(companyManager);
        }

        public async Task<UpdateCompanyManagerDto> GetCompanyManagerById(int id)
        {
            var companyManager = await _companyManagerRepo.GetFilteredFirstOrDefault(select: x => _mapper.Map<UpdateCompanyManagerDto>(x),
                                                                                     where: x => x.Id == id);
            return companyManager;
        }

        public async Task<List<ListCompanyManagerDto>> GetCompanyManagers()
        {
            var companyManager = await _companyManagerRepo.GetFilteredList(select: x => new ListCompanyManagerDto

            {
                FirstName = x.FirstName,
                SecondName = x.SecondName,
                LastName = x.LastName,
                SecondLastName = x.SecondLastName,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                CompanyId = x.CompanyId,
                CompanyName = x.Company.CompanyName,
            },

                                                                           where: x => !x.Status.Equals(Status.Pasive),
                                                                           orderBy: x => x.OrderBy(x => x.CompanyId),
                                                                           include: query => query.Include(x => x.Company));

            return companyManager;
        }

        public async Task<List<ListCompanyManagerDto>> GetCompanyManagersByCompany(int companyId)
        {
            var companyManager = await _companyManagerRepo.GetFilteredList(select: x => _mapper.Map<ListCompanyManagerDto>(x),
                                                                           where: x => x.CompanyId.Equals(companyId),
                                                                           orderBy: x => x.OrderBy(x => x.Id));
            return companyManager;
        }

        public async Task<SummaryCompanyManagerDto> GetCompanyManagerSummary(int id)
        {
            var companyManager = await _companyManagerRepo.GetFilteredFirstOrDefault(select: x => _mapper.Map<SummaryCompanyManagerDto>(x),
                                                                                     where: s => s.Id.Equals(id) && s.Status != Status.Pasive);

            string imageString = null;

            if (companyManager != null && companyManager.ImageBytes != null)
                imageString = Convert.ToBase64String(companyManager.ImageBytes);
            companyManager.ImageString = imageString;

            return companyManager;
        }

        public async Task<DetailCompanyManagerDto> GetCompanyManagerDetails(int id)
        {
            var companyManager = await _companyManagerRepo.GetFilteredFirstOrDefault(select: x => _mapper.Map<DetailCompanyManagerDto>(x),
                                                                                     where: s => s.Id.Equals(id) && s.Status != Status.Pasive);

            string imageString = null;

            if (companyManager != null && companyManager.ImageBytes != null)

                imageString = Convert.ToBase64String(companyManager.ImageBytes);

            companyManager.ImageString = imageString;

            return companyManager;
        }


        public async Task SoftDelete(int id)
        {
            var companyManager = await _companyManagerRepo.GetDefault(x => x.Id.Equals(id));

            if (companyManager is not null)
            {
                companyManager.DeletedDate = DateTime.Now;
                companyManager.Status = Status.Pasive;
                await _companyManagerRepo.Update(companyManager);
            }
        }

        public async Task<CompanyManager> Update(UpdateCompanyManagerDto model)
        {
            var companyManager = await _companyManagerRepo.GetDefault(x => x.Id == model.Id);

            companyManager.Address = model.Address;
            companyManager.PhoneNumber = model.PhoneNumber;

            if (model.ImageString is not null)
                companyManager.ImageBytes = Convert.FromBase64String(model.ImageString);

            companyManager.Status = Status.Modified;
            companyManager.UpdatedDate = DateTime.Now;

            await _companyManagerRepo.Update(companyManager);

            return companyManager;
        }
        #endregion

        #region Off Day
        public async Task<List<ApprovalOffDayDto>> WaitingApprovalForOffDay()
        {
            var listOfWaitingApprovalForDayOff = await _takeOffDayRepo.GetFilteredList(select: x => _mapper.Map<TakeOffDay>(x),
                where: x => x.ApprovalType == ApprovalType.Waiting);

            var dtoList = _mapper.Map<List<ApprovalOffDayDto>>(listOfWaitingApprovalForDayOff);

            return dtoList;
        }
        #endregion

        #region Expense
        public async Task<List<ApprovalForExpenseDto>> WaitingApprovalForExpense(int id)
        {
            var listOfWaitingApprovalForExpense = await _employeeRepo.GetFilteredList(select: x => _mapper.Map<Employee>(x), where: x => x.Id == id);
            var employeeIds = listOfWaitingApprovalForExpense.Select(u => u.Id).ToList();

            var listOfWaitingApprovalForAdvance = await _advancePaymentRepo.GetFilteredList(select: x => _mapper.Map<Expense>(x),
                where: x => x.ApprovalType == ApprovalType.Waiting && employeeIds.Contains(x.EmployeeId.Value));

            var dtoList = _mapper.Map<List<ApprovalForExpenseDto>>(listOfWaitingApprovalForExpense);

            return dtoList;
        }
        #endregion

        #region Advance Payment
        public async Task<List<ApprovalForAdvancePaymentDto>> WaitingApprovalForAdvancePayment(int companyManagerId)
        {
            var employeesAssignedToManager = await _employeeRepo.GetFilteredList(select: x => _mapper.Map<Employee>(x),where: x => x.CompanyManagerId == companyManagerId);

            var employeeIds = employeesAssignedToManager.Select(u => u.Id).ToList();

            var listOfWaitingApprovalForAdvance = await _advancePaymentRepo.GetFilteredList(select: x => _mapper.Map<AdvancePayment>(x),
                where: x => x.ApprovalType == ApprovalType.Waiting && employeeIds.Contains(x.EmployeeId.Value));

            var dtoList = _mapper.Map<List<ApprovalForAdvancePaymentDto>>(listOfWaitingApprovalForAdvance);

            return dtoList;
        }
        #endregion

    }
}

