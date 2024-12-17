namespace Drive.Data.Entities.Models
{
    public class Folder : Item
    {
        public int? ParentFolderId { get; set; }
        public Folder ParentFolder { get; set; }

        public List<File> Files { get; set; } = new List<File>();
    }
}
