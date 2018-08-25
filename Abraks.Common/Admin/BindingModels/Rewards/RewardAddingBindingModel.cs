namespace Abraks.Common.Admin.BindingModels.Rewards
{
    using System.ComponentModel.DataAnnotations;
    using Constants;

    public class RewardAddingBindingModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(DataConstants.NamesMinLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(DataConstants.NamesMinLength)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Poster")]
        public string ImageUrl { get; set; }

        [Required]
        public string Event { get; set; }
    }
}
