using Microsoft.AspNetCore.Identity;

namespace WebAppAuthorization.Data.Identity
{
    public class ApplicationIdentityUser : IdentityUser
    {
        public string City { get; set; }
    }
}