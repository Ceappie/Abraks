namespace Abraks.Models
{
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        [Required]
        [MinLength(DataConstants.NamesMinLength)]
        public string FullName { get; set; }
    }
}
