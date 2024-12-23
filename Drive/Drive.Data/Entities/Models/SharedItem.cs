namespace Drive.Data.Entities.Models
{
    public class SharedItem
    {
        public SharedItem(int itemId, int userId)
        {
            ItemId = itemId;
            UserId = userId;
        }
        public int SharedItemId { get; set; }

        public int ItemId { get; set; }
        public Item? Item { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}