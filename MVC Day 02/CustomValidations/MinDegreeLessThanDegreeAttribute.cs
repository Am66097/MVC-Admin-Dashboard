using MVC_Day_02.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_Day_02.CustomValidations
{
    public class MinDegreeLessThanDegreeAttribute : ValidationAttribute
    {
        // Day 05 
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int MinDegree = (int)value;

            Course courseTotalDegree = (Course)validationContext.ObjectInstance;

            if (courseTotalDegree.Degree < MinDegree)
            {
                return new ValidationResult("Success Degree Can Not Be Bigger Than Course Total Degree");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}