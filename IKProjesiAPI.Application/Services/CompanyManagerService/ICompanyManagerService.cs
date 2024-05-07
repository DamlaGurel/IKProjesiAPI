using System.Runtime.InteropServices;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Application.Models.DTOs.AdvancePaymentDTOs;
using IKProjesiAPI.Application.Models.DTOs.OffDayDTOs;
using IKProjesiAPI.Application.Models.DTOs.ExpenseDTOs;




namespace IKProjesiAPI.Application.Services.CompanyManagerService
{
    public interface ICompanyManagerService
    {
        Task<CreateCompanyManagerDto> Create(CreateCompanyManagerDto model);
        Task Update(UpdateCompanyManagerDto model);
        Task Delete(int id);
        Task SoftDelete(int id);
        Task<List<ListCompanyManagerDto>> GetCompanyManagers();
        Task<UpdateCompanyManagerDto> GetCompanyManagerById(int id);
        Task<List<ListCompanyManagerDto>> GetCompanyManagersByCompany(int companyId);
        Task<SummaryCompanyManagerDto> GetCompanyManagerSummary(int id);
        Task<DetailCompanyManagerDto> GetCompanyManagerDetails(int id);


        Task<List<ApprovalOffDayDto>> WaitingApprovalForOffDay();

        Task<List<ApprovalForExpenseDto>> WaitingApprovalForExpense();

        Task<List<ApprovalForAdvancePaymentDto>> WaitingApprovalForAdvancePayment();



    }
}

