namespace BlogBETA.Models
{
    public class Blog
    {
        int Id { get; set; }
        int OwnerId { get; set; }
        string? Discription { get; set; }
        public virtual List<Post>? Posts { get; set; }

    }
}
