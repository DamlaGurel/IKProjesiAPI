using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using IKProjesiAPI.Domain.Repositories;

namespace IKProjesiAPI.Application.Services.SiteManagerService
{
    public class SiteManagerService : ISiteManagerService
    {
        private readonly ISiteManagerRepo _siteManagerRepo;
        private readonly IAppUserRepo _appUserRepo;
        private readonly IMapper _mapper;

        public SiteManagerService(ISiteManagerRepo siteManagerRepo, IMapper mapper, IAppUserRepo appUserRepo)
        {
            _siteManagerRepo = siteManagerRepo;
            _mapper = mapper;
            _appUserRepo = appUserRepo;
        }


        public async Task<CreateSiteManagerDto> CreateSiteManager(CreateSiteManagerDto model)
        {
            var email = await _appUserRepo.GenerateUniqueEmail(model.FirstName, model.LastName);

            var siteManager = _mapper.Map<SiteManager>(model);

            siteManager.Email = email;
            siteManager.NormalizedEmail = email.ToUpper();
            siteManager.UserName = siteManager.Email;
            siteManager.NormalizedUserName = siteManager.Email.ToUpper();
            siteManager.JobName = Job.SiteManager;
            siteManager.ImageBytes = Convert.FromBase64String(model.ImageString);
            siteManager.CreatedDate = DateTime.Now;
            siteManager.Status = Status.Active;

            await _siteManagerRepo.Create(siteManager);
            return _mapper.Map<CreateSiteManagerDto>(siteManager);
        }

        //public async Task<string> GetUserEmail(string firstName, string lastName)
        //{
        //    string email = $"{firstName}.{lastName}@bilgeadam.com";
        //    var userEmail = await _siteManagerRepo.GetFilteredFirstOrDefault(select: u => u.Email,
        //     where: u => u.Email == email);
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
            var siteManager = await _siteManagerRepo.GetFilteredFirstOrDefault(select: x => _mapper.Map<SiteManagerDetailsDto>(x),
                                                                               where: s => s.Id.Equals(id) && s.Status != Status.Pasive);

            return siteManager;
        }

        public async Task<SiteManagerSummaryDto> GetSiteManagerSummary(int id)
        {
            var siteManager = await _siteManagerRepo.GetFilteredFirstOrDefault(select: x => _mapper.Map<SiteManagerSummaryDto>(x),
                                                                               where: s => s.Id.Equals(id) && s.Status != Status.Pasive);

            return siteManager;
        }

        public async Task UpdateSiteManager(SiteManagerUpdateDto model)
        {
            var siteManager = await _siteManagerRepo.GetDefault(x => x.Id == model.Id);

            siteManager.Address = model.Address;
            siteManager.PhoneNumber = model.PhoneNumber;
            //siteManager.ImagePath = model.ImagePath;

            siteManager.Status = Status.Modified;
            siteManager.UpdatedDate = DateTime.Now;

            await _siteManagerRepo.Update(siteManager);
        }

        public async Task DeleteSiteManager(int id)
        {
            var siteManager = await GetSiteManager(id);

            if (siteManager != null)
                await _siteManagerRepo.Delete(siteManager);
            else
                throw new Exception("Site manager not found ! ");

        }

        public async Task SoftDeleteSiteManager(int id)
        {
            var siteManager = await GetSiteManager(id);

            if (siteManager is not null)
            {
                siteManager.Status = Status.Pasive;
                siteManager.DeletedDate = DateTime.Now;
                await _siteManagerRepo.Update(siteManager);
            }
        }

        public async Task<List<SiteManagerDetailsDto>> SiteManagerDetails()
        {
            var siteManager = await _siteManagerRepo.GetFilteredList(select: s => _mapper.Map<SiteManagerDetailsDto>(s),
                                                                     where: s => !s.Status.Equals(Status.Pasive));
            return siteManager;
        }
    }
}
