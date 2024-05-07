using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace IKProjesiAPI.Application.Extensions
{
    public class PictureFileExtensionAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            IFormFile file = value as IFormFile;
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();

                string[] extensions = { "jpg", "jpeg", "png" };

                bool result = extensions.Any(x => extension.EndsWith(x));

                if (!result)
                {
                    return new ValidationResult("Geçerli formatta bir dosya yükleyiniz. (\"jpg\", \"jpeg\", \"png\") ");
                }
                return ValidationResult.Success;
            }
            return new ValidationResult("Null Değer geldi.");
        }
    }

}

