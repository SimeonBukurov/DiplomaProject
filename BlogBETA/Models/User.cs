using Microsoft.AspNetCore.Identity;

namespace BlogBETA.Models
{
    public class User : IdentityUser
    {
        public virtual ICollection<Post>? Posts { get; set; }   
    }
}
