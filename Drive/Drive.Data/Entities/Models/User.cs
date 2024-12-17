namespace Drive.Data.Entities.Models
{
    public class User
    {
        public User(string email, string password, DateTime createdAt)
        {
            Email = email;
            Password = password;
            CreatedAt = createdAt;
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public int DiskId { get; set; }
        public Disk Disk { get; set; }

        public List<SharedItem> SharedItems { get; set; } = new List<SharedItem>();
    }
}
