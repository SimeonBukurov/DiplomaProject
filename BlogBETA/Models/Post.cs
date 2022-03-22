namespace BlogBETA.Models
{
    public class Post
    {
      public int Id { get; set; }
      public  int BlogId { get; set; }
      public  int UserId { get; set; }
      public virtual Blog? Blog { get; set; }
      public  DateTime TimeCreated { get; set; } = DateTime.Now;
      public string? Content { get; set; }
      public virtual User? User { get; set; }
    }
}
