using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsOldIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MemberShipTypeId == 1 || customer.MemberShipTypeId == 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                if (customer.Bith == null)
                {
                    return new ValidationResult("The date of birth is required");
                }

                var age = DateTime.Now.Year - customer.Bith.Value.Year;
                return (age >= 18)
                    ? ValidationResult.Success
                    : new ValidationResult("You must be at least 18 years old to be a member");
            }
        }
    }
}