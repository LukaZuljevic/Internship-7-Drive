namespace Drive.Data.Entities.Models
{
    public abstract class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastChangedAt { get; set; }

        public int DiskId { get; set; }
        public Disk Disk { get; set; } = null!;

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
