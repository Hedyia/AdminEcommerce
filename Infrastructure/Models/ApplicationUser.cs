using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Models
{
   public class ApplicationUser : IdentityUser
    {
        [MaxLength(128)]
        public string DisplayName { get; set; }
    }
}