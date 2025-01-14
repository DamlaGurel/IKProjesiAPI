﻿using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Domain.Entities;

namespace IKProjesiAPI.Application.Services.SiteManagerService
{
    public interface ISiteManagerService
    {
        Task<CreateSiteManagerDto> CreateSiteManager(CreateSiteManagerDto model);
        Task<SiteManager> UpdateSiteManager(SiteManagerUpdateDto model);
        Task DeleteSiteManager(int id);
        Task SoftDeleteSiteManager(int id);
        Task<SiteManager> GetSiteManager(int id);
        Task<SiteManagerDetailsDto> GetSiteManagerDetails(int id);
        Task<SiteManagerSummaryDto> GetSiteManagerSummary(int id);
        Task<List<SiteManagerDetailsDto>> SiteManagerDetails();
        //Task<string> GetUserEmail(string firstName, string lastName);
        Task<SiteManagerUpdateDto> GetSiteManagerById(int id);

    }
}
