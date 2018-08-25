namespace Abraks.Common.Admin.BindingModels.Events
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Constants;
    using ValidationAttribute;

    public class EventAddingBindingModel
    {
        [Required]
        [MinLength(DataConstants.NamesMinLength)]
        public string Name { get; set; }

        [Required]
        public string Dance { get; set; }

        [Required]
        public string Place { get; set; }

        public string Address { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Poster")]
        public string PosterUrl { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "From")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [EndDate("StartDate")]
        [Display(Name = "To")]
        public DateTime EndDate { get; set; }
    }
}
