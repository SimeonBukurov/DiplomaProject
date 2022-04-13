namespace BlogBETA.Models
{
    public class Post
    {
      public int Id { get; set; }
      public virtual Blog? Blog { get; set; }
      public int BlogId { get; set; }
      public  DateTime TimeCreated { get; set; } = DateTime.Now;
      public string? Content { get; set; }
      public virtual User? Owner { get; set; }  
      public  string? OwnerId { get; set; }
    }
}
