using System.ComponentModel.DataAnnotations;

namespace ManipulatingResources.Api.Helpers.Validations
{
    public class NonNegativeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null || (int)value == 0)
                return ValidationResult.Success;

            if ((decimal)value < 0)
                return new ValidationResult("The number cannot be negative.");

            return ValidationResult.Success;
        }
    }
}
