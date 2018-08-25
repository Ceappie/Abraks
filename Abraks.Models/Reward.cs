namespace Abraks.Models
{
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class Reward
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
        public string ImageUrl { get; set; }

        [Required]
        public int EventId { get; set; }

        public Event Event { get; set; }
    }
}
