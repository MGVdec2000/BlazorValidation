using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlazorValidation;

public class ApplicationUser : IdentityUser
{
    public bool MustChangePassword { get; set; } = false;

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
}
