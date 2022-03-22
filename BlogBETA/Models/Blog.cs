namespace BlogBETA.Models
{
    public class Blog
    {
        public int? Id { get; set; }
        public int? OwnerId { get; set; }
        public string? Discription { get; set; }
        public virtual ICollection<Post>? Posts { get; set; }

    }
}
