using System;
using System.ComponentModel.DataAnnotations;

namespace survey.Models
{
    public class Survey
    {
        [Display(Name="name: ", Prompt="Enter your name here")]
        [Required(ErrorMessage="Name is required.")]
        [MinLength(4, ErrorMessage="Name must be at least 2 characters.")]
        public string name { get; set; }

        [Display(Name="location: ", Prompt="Choose your location")]
        [Required(ErrorMessage="Location is required.")]
        public string location { get; set; }

        [Display(Name="language: ", Prompt="Choose your language")]
        [Required(ErrorMessage="Language is required.")]
        public string language { get; set; }

        [Display(Name="comment: ")]
        [MinLength(4, ErrorMessage="Comment must be at least 20 characters.")]
        public string comment { get; set; }

        [Display(Name="date: ")]
        [DateValidator]
        public DateTime date { get ; set; }
        
    }

    public class DateValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if((DateTime)value> DateTime.Now)
            {
                return new ValidationResult("Posted time must be a previous time.");
            }
            return ValidationResult.Success;
        }
    }

}