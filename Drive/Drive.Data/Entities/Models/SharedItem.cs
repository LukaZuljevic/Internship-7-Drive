namespace Drive.Data.Entities.Models
{
    public class SharedItem
    {
        public int SharedItemId { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int UserSharedToId { get; set; }
        public User UserSharedTo { get; set; }

        public string Permissions { get; set; }//napravi kao enum
    }
}
