namespace Drive.Data.Entities.Models
{
    public class Folder : Item
    {
        public Folder(string name) : base(name)
        {

        }
        public Folder(string name, int parentFolderId, int diskId) : base(name)
        {
            ParentFolderId = parentFolderId;
            DiskId = diskId;
        }
        //public List<Files> Files { get; set; } = new List<Files>();
    }
}
