using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Extensions
{
    public class DateTimeValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            var startDateProperty = validationContext.ObjectType.GetProperty("StartDateOfWork");
            var startDateValue = (DateTime?)startDateProperty.GetValue(validationContext.ObjectInstance, null);

            var birthDateValue = (DateTime?)value;

            if (birthDateValue.HasValue && startDateValue.HasValue)
            {
                if (birthDateValue > startDateValue)
                {
                    return new ValidationResult("Doğum tarihi işe başlama tarihinden büyük olamaz.");
                }
            }
            return base.IsValid(value, validationContext);
        }    
    }
}
