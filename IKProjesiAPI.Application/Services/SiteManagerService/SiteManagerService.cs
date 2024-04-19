﻿using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using IKProjesiAPI.Domain.Repositories;

namespace IKProjesiAPI.Application.Services.SiteManagerService
{
    public class SiteManagerService : ISiteManagerService
    {
        private readonly ISiteManagerRepo _siteManagerRepo;
        private readonly IMapper _mapper;

        public SiteManagerService(ISiteManagerRepo siteManagerRepo, IMapper mapper)
        {
            _siteManagerRepo = siteManagerRepo;
            _mapper = mapper;
        }

        public async Task Add(AddSiteManagerDto model)
        {
            var siteManager = _mapper.Map<SiteManager>(model);

            siteManager.JobName = Job.SiteManager;
            siteManager.CreatedDate = DateTime.Now;
            siteManager.Status = Status.Active;
           
            await _siteManagerRepo.Create(siteManager);
        }

        public async Task<SiteManager> GetSiteManager(int id)
        {
            var sitemanager = await _siteManagerRepo.GetDefault(x => x.Id == id);
            return sitemanager;
        }

        public async Task<SiteManagerDetailsDto> GetSiteManagerDetails(int id)
        {
            var siteManager = await _siteManagerRepo.GetFilteredFirstOrDefault(
                select: x => _mapper.Map<SiteManagerDetailsDto>(x),
                where: s => s.Id.Equals(id) && s.Status != Status.Pasive);

            return siteManager;
        }

        public async Task<SiteManagerSummaryDto> GetSiteManagerSummary(int id)
        {
            var siteManager = await _siteManagerRepo.GetFilteredFirstOrDefault(
                select: x => _mapper.Map<SiteManagerSummaryDto>(x),
                where: s => s.Id.Equals(id) && s.Status != Status.Pasive);

            return siteManager;
        }

        public async Task Update(SiteManagerUpdateDto model)
        {
            var siteManager = _mapper.Map<SiteManager>(model);

            siteManager.Status = Status.Modified;
            siteManager.UpdatedDate = DateTime.Now;

            await _siteManagerRepo.Update(siteManager);
        }



    }
}
