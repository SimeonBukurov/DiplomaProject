using Microsoft.AspNetCore.Identity;

namespace BlogBETA.Models
{
    public class User : IdentityUser
    {
        public virtual List<Post>? Posts { get; set; }       
    }
}
