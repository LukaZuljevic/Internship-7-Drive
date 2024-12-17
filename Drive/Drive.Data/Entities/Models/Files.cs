namespace Drive.Data.Entities.Models
{
    public class Files : Item
    {
        public string Content { get; set; }

        public int FolderId { get; set; }
        public Folder? Folder { get; set; }
    }
}
