using System.Runtime.InteropServices;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Domain.Entities;

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
        Task<List<ApprovalForOffDayDto>> WaitingApprovalForDayOff();

        Task<List<ApprovalForExpenseDto>> WaitingApprovalForExpense();

        Task<List<ApprovalForAdvanceDto>> WaitingApprovalForAdvance();



    }
}

