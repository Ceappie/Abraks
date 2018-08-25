namespace Abraks.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [MinLength(DataConstants.CommentContentMinLength)]
        [MaxLength(DataConstants.CommentContentMaxLength)]
        public string Content { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        public int EventId { get; set; }

        public Event Event { get; set; }
    }
}
