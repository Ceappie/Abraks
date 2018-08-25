namespace Abraks.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class Event
    {
        public Event()
        {
            this.Rewards = new List<Reward>();
            this.Comments = new List<Comment>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(DataConstants.NamesMinLength)]
        public string Name { get; set; }

        [Required]
        public DanceType Dance { get; set; }

        [Required]
        [MinLength(DataConstants.NamesMinLength)]
        public string Place { get; set; }

        public string Address { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string PosterUrl { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public ICollection<Reward> Rewards { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
