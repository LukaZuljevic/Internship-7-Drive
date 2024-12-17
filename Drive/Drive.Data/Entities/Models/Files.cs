namespace Drive.Data.Entities.Models
{
    public class Files : Item
    {
        public Files(string name, string content) : base(name)
        {
            Content = content;
        }

        public string Content { get; set; }
    }
}
