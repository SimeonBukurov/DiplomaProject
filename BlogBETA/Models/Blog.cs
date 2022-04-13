namespace BlogBETA.Models
{
    public class Blog
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Discription { get; set; }
        public virtual List<Post>? Posts { get; set; }
        public virtual ICollection<User>? Users { get; set; }
    }
}
