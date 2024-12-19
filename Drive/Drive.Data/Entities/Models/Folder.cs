namespace Drive.Data.Entities.Models
{
    public class Folder : Item
    {
        public Folder(string name) : base(name)
        {

        }
        public List<Files> Files { get; set; } = new List<Files>();
    }
}
