﻿using AutoMapper;
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
                
        public async Task<CreatePersonelDto> CreatePersonel(CreatePersonelDto model)
        {
            var personel = _mapper.Map<Personel>(model);
            personel.Email=$"{personel.FirstName}.{personel.LastName}@bilgeadamboost.com";
            personel.UserName = personel.Email;
            personel.NormalizedUserName = personel.Email.ToUpper();
            personel.JobName = Domain.Enums.Job.Personel;
            await _personelRepo.Create(personel);

            var p = _mapper.Map<CreatePersonelDto>(personel);
            return p;
        }


        // Expence işlemleri 





    }
}
