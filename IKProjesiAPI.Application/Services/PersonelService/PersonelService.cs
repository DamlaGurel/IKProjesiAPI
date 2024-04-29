using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Services.PersonelService
{
    public class PersonelService : IPersonelService
    {
        private readonly IPersonelRepo _personelRepo;
        private readonly IMapper _mapper;

        public PersonelService(IPersonelRepo personelRepo, IMapper mapper)
        {
            _personelRepo = personelRepo;
            _mapper = mapper;
        }
                
        public async Task CreatePersonel(CreatePersonelDto model)
        {
            var personel = _mapper.Map<Personel>(model);

            await _personelRepo.Create(personel);
        }
    }
}
