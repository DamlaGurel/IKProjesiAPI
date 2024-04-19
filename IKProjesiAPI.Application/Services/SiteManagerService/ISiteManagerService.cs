
using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Domain.Entities;

namespace IKProjesiAPI.Application.Services.SiteManagerService
{
    public interface ISiteManagerService
    {
        Task Add(AddSiteManagerDto model);
        Task<SiteManager> GetSiteManager(int id);
        Task<SiteManagerDetailsDto> GetSiteManagerDetails(int id);
        Task<SiteManagerSummaryDto> GetSiteManagerSummary(int id);
        Task Update(SiteManagerUpdateDto model);
        Task Delete(int id);

    }
}
