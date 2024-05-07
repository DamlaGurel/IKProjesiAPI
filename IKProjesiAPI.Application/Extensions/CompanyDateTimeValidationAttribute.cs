using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Extensions
{
    public class CompanyDateTimeValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {

            var startContractDateProperty = validationContext.ObjectType.GetProperty("StartContractDate");

            var startContractDateValue = (DateTime?)startContractDateProperty.GetValue(validationContext.ObjectInstance, null);

            var endContractDateProperty = validationContext.ObjectType.GetProperty("EndContractDate");

            var endContractDateValue = (DateTime?)endContractDateProperty.GetValue(validationContext.ObjectInstance, null);

            var foundationYearValue = (DateTime?)value;

            if (foundationYearValue.HasValue && startContractDateValue.HasValue && endContractDateValue.HasValue)
            {
                if (foundationYearValue > startContractDateValue || foundationYearValue > endContractDateValue)
                {
                    return new ValidationResult("Kuruluş yılı, sözleşme başlangıç ya da bitiş tarihinden sonra olamaz.");
                }
                if (startContractDateValue > endContractDateValue)
                {
                    return new ValidationResult("Sözleşme başlangıç tarihi bitiş tarihinden sonra olamaz");
                }
            }

            return base.IsValid(value, validationContext);
        }
    }
}
