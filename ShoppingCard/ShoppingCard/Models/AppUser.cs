using Microsoft.AspNetCore.Identity;

namespace ShoppingCard.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }

    }
}
