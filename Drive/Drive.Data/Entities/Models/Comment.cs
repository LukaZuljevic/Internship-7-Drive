namespace Drive.Data.Entities.Models
{
    public class Comment
    {
        public Comment(string content)
        {
            Content = content;
        }

        public int CommentId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Today;

        public int ItemId { get; set; }
        public Item? Item { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
