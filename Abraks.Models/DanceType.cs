namespace Abraks.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class DanceType
    {
        public DanceType()
        {
            this.Events = new List<Event>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(DataConstants.NamesMinLength)]
        public string Name { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}