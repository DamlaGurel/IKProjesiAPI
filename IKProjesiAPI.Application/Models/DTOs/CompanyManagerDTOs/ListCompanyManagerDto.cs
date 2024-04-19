using System;
using IKProjesiAPI.Application.Extensions;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs
{
    public class ListCompanyManagerDto
    {
        public int? Id { get; set; }
        // string mi int mi aldık??

        [Required(ErrorMessage = "Şirket yöneticisi isminin girilmesi zorunludur.")]
        [Display(Name = "İsim")]
        public string FirstName { get; set; }

        [Display(Name = "İkinci İsim")]
        public string? SecondName { get; set; }

        [Required(ErrorMessage = "Şirket yöneticisi soyisminin girilmesi zorunludur.")]
        [Display(Name = "Soyisim")]
        public string LastName { get; set; }

        [Display(Name = "İkinci Soyisim")]
        public string? SecondLastName { get; set; }


        [Display(Name = "E-posta")]
        public string Email { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }


        //Company gösterme
        public int CompanyId { get; set; }
        public Company? CompanyManagersCompany { get; set; }
    }
}

