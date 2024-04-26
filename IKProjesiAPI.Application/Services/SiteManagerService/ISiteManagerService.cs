
using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Domain.Entities;

namespace IKProjesiAPI.Application.Services.SiteManagerService
{
    public interface ISiteManagerService
    {
        Task<CreateSiteManagerDto> CreateSiteManager(CreateSiteManagerDto model);
        Task UpdateSiteManager(SiteManagerUpdateDto model);
        Task DeleteSiteManager(int id);
        Task SoftDeleteSiteManager(int id);
        Task<SiteManager> GetSiteManager(int id);
        Task<SiteManagerDetailsDto> GetSiteManagerDetails(int id);
        Task<SiteManagerSummaryDto> GetSiteManagerSummary(int id);
        //Task<string> GetUserEmail(string firstName, string lastName);

    }
}
