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
        #region Company Manager
        Task<CreateCompanyManagerDto> Create(CreateCompanyManagerDto model);
        Task<CompanyManager> Update(UpdateCompanyManagerDto model);
        Task Delete(int id);
        Task SoftDelete(int id);
        Task<List<ListCompanyManagerDto>> GetCompanyManagers();
        Task<UpdateCompanyManagerDto> GetCompanyManagerById(int id);
        Task<List<ListCompanyManagerDto>> GetCompanyManagersByCompany(int companyId);
        Task<SummaryCompanyManagerDto> GetCompanyManagerSummary(int id);
        Task<DetailCompanyManagerDto> GetCompanyManagerDetails(int id);
        #endregion

        #region Off Day
        Task<List<ApprovalOffDayDto>> WaitingApprovalForOffDay();
        #endregion

        #region Expense
        Task<List<ApprovalForExpenseDto>> WaitingApprovalForExpense();
        #endregion

        #region Advance Payment
        Task<List<ApprovalForAdvancePaymentDto>> WaitingApprovalForAdvancePayment(int id);
        #endregion
    }
}

