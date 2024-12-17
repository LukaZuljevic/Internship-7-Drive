namespace Drive.Data.Entities.Models
{
    public class User
    {
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);
        public int DiskId { get; set; }
        public Disk Disk { get; set; }

        public List<SharedItem> SharedItems { get; set; } = new List<SharedItem>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
