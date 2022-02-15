using System.ComponentModel.DataAnnotations;

namespace Dietician.Atributes
{
    public class ToExpensiveValidations :ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime birthday = (DateTime)value;
            if (birthday.Year < 1900)
                return new ValidationResult("Surely food is that old?");
            if (birthday.Year > 2022)
                return new ValidationResult("Recipe from future!");
            if (birthday.Month == 7)
                return new ValidationResult("...July? And over 50?");
            return ValidationResult.Success;
        }
    }
}
