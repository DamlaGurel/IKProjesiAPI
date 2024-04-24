using System.Linq.Expressions;
using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using IKProjesiAPI.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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


        public async Task Create(CreateSiteManagerDto model)
        {
            var siteManager = _mapper.Map<SiteManager>(model);

            siteManager.Email = $"{model.FirstName}.{model.LastName}@bilgeadam.com";
            siteManager.UserName = model.UserName;
            siteManager.NormalizedUserName = model.UserName.ToUpper();
            siteManager.JobName = Job.SiteManager;
            siteManager.CreatedDate = DateTime.Now;
            siteManager.Status = Status.Active;

            await _siteManagerRepo.Create(siteManager);
        }
        //public async Task<string> GetUserEmail(string firstName, string lastName)
        //{
        //    string email = $"{firstName}.{lastName}@bilgeadam.com";
        //   var userEmail= await _siteManagerRepo.GetFilteredFirstOrDefault(select: u => u.Email,
        //    where: u => u.Email == email);
        //    return email;
        //}



        public async Task<SiteManager> GetSiteManager(int id)
        {
            var siteManager = await _siteManagerRepo.GetDefault(x => x.Id == id);

            if (siteManager is not null)
                return siteManager;
            else
                throw new Exception("Site manager not found ! ");
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
            //var siteManager = await _siteManagerRepo.GetFilteredFirstOrDefault(
            //    select: x => _mapper.Map<SiteManagerSummaryDto>(x),
            //    where: s => s.Id.Equals(id) && s.Status != Status.Pasive);

            var siteManager = await GetSiteManager(id);
                //await _siteManagerRepo.GetDefault(x => x.Id == id);
            var siteManagerDto = _mapper.Map<SiteManagerSummaryDto>(siteManager);

            return siteManagerDto;
        }

        public async Task Update(SiteManagerUpdateDto model)
        {
            var siteManager = await _siteManagerRepo.GetDefault(x => x.Id == model.Id);
            siteManager.Address = model.Address;

            //var updateSiteManager = _mapper.Map<SiteManager>(model);

            siteManager.Status = Status.Modified;
            siteManager.UpdatedDate = DateTime.Now;

            await _siteManagerRepo.Update(siteManager);
        }

        public async Task Delete(int id)
        {
            var siteManager = await GetSiteManager(id);

            if (siteManager != null)
                await _siteManagerRepo.Delete(siteManager);
            else
                throw new Exception("Site manager not found ! ");

        }

        public async Task SoftDelete(int id)
        {
            var siteManager = await GetSiteManager(id);

            if (siteManager is not null)
            {
                siteManager.Status = Domain.Enums.Status.Pasive;
                siteManager.DeletedDate = DateTime.Now;
                await _siteManagerRepo.Update(siteManager);
            }
        }

    }
}
