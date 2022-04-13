namespace BlogBETA.Models
{
    public class Blog
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Discription { get; set; }
        public virtual User? Owner { get; set; }
        public string? OwnerId { get; set; }
        public virtual ICollection<Post>? Posts { get; set; }

    }
}
