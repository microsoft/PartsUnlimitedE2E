using Microsoft.AspNet.Identity.EntityFramework;

namespace PartsUnlimited.Models
{
    // Last comment
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}