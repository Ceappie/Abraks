namespace Abraks.Common.Admin.BindingModels.Comments
{
    using System.ComponentModel.DataAnnotations;

    public class CommentCreatingBindingModel
    {
        [Required]
        public string Content { get; set; }

        [Required]
        public int EventId { get; set; }
    }
}
