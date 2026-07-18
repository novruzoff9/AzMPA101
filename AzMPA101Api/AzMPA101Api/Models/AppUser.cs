using Microsoft.AspNetCore.Identity;

namespace AzMPA101Api.Models;

public class AppUser : IdentityUser
{
    public string FullName { get; set; }
}
