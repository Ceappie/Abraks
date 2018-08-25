namespace Abraks.Common.ValidationAttribute
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class EndDate : ValidationAttribute
    {
        private readonly string startDate;

        public EndDate(string startDate)
        {
            this.startDate = startDate;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var currentValue = (DateTime)value;

            var property = validationContext.ObjectType.GetProperty(startDate);

            if (property == null)
                throw new ArgumentException("Property with this name not found");

            var comparisonValue = (DateTime)property.GetValue(validationContext.ObjectInstance);

            if (currentValue >= comparisonValue)
            {
                return new ValidationResult("End Date must be after Start Date.");
            }

            return ValidationResult.Success;
        }
    }
}