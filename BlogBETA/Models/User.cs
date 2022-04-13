using Microsoft.AspNetCore.Identity;

namespace BlogBETA.Models
{
    public class User : IdentityUser
    {    
        public virtual List<Post>? Posts { get; set; }   
        public int ? PostId { get; set; }
        public virtual Blog? Blog { get; set; }
        public int ? BlogId { get; set; }
    }
}
