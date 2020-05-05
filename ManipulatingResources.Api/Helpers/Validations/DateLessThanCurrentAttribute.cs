using System;
using System.ComponentModel.DataAnnotations;

namespace ManipulatingResources.Api.Helpers.Validations
{
    public class DateLessThanCurrentAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) 
                return ValidationResult.Success;

            if ((DateTime)value < DateTime.Now)
                return new ValidationResult("The date cannot be less than the current date.");

            return ValidationResult.Success;
        }
    }
}
