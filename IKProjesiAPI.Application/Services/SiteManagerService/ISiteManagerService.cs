
using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Domain.Entities;

namespace IKProjesiAPI.Application.Services.SiteManagerService
{
    public interface ISiteManagerService
    {
        Task Create(CreateSiteManagerDto model);
        Task Update(SiteManagerUpdateDto model);
        Task Delete(int id);
        Task SoftDelete(int id);
        Task<SiteManager> GetSiteManager(int id);
        Task<SiteManagerDetailsDto> GetSiteManagerDetails(int id);
        Task<SiteManagerSummaryDto> GetSiteManagerSummary(int id);
        //Task<string> GetUserEmail(string firstName, string lastName);

    }
}
