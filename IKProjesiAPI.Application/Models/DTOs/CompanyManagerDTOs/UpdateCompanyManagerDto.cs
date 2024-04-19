using System;
using IKProjesiAPI.Application.Extensions;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs
{
	public class UpdateCompanyManagerDto
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

        [Display(Name = "Profil Fotoğrafı")]
        [PictureFileExtension]
        public IFormFile? ProfilePicture { get; set; }
        public string? ImagePath { get; set; }

        [Display(Name = "Doğum Tarihi")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Doğum Yeri")]
        public string BirthPlace { get; set; }

        [Required(ErrorMessage = "TC Kimlik numarası girilmesi zorunludur.")]
        [Display(Name = "TC Kimlik Numarası")]
        [IdentificationNumberValidation(ErrorMessage = "Lütfen geçerli bir TC Kimlik numarası giriniz.")]
        public string IdentityNumber { get; set; }

        [Display(Name = "İşe Başlangıç Tarihi")]
        public DateTime? StartDateOfWork { get; set; }

        [Display(Name = "Meslek")]
        public Job JobName { get; set; }

        [Display(Name = "Departman Adı")]
        public Department DepartmentName { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }

        [Display(Name = "E-posta")]
        public string Email { get; set; }

        public DateTime UpdateDate => DateTime.Now;

        public Status Status => Status.Modified;

        //Company Seçim 
        public int CompanyId { get; set; }
        public List<Company> Companies { get; set; } //burada list içerisine vm dto companyden alınıp koyulca!!
    }
}

