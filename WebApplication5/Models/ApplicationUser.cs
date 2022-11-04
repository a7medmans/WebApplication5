using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required , MaxLength(100)]
        public string FirstName { get; set; }

        [Required , MaxLength(100)]
        public string LastName { get; set; }
        public byte[]? Profilepicture { get; set; }

    }
}
