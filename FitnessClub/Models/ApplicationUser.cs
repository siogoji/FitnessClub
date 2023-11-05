using Microsoft.AspNetCore.Identity;

namespace FitnessClub.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
