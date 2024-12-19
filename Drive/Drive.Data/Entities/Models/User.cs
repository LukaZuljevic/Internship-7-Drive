namespace Drive.Data.Entities.Models
{
    public class User
    {
        private static int _nextDiskId = 1;

        public User(string email, string password)
        {
            Email = email;
            Password = password;
            DiskId = _nextDiskId++;
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int DiskId { get; set; }
        public Disk Disk { get; set; } = null!;

        public List<SharedItem> SharedItems { get; set; } = new List<SharedItem>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}