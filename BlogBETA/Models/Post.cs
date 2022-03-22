namespace BlogBETA.Models
{
    public class Post
    {
      public int Id { get; set; }
      public  int BlogId { get; set; }
      public  int UserId { get; set; }
      public  DateTime TimeCreated { get; set; }
      public  string Content { get; set; }
    }
}
