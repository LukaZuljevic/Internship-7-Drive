using Drive.Data.Entities.Models;

namespace Drive.Presentation.Actions
{
    public class CurrentFolder
    {

        public Folder? Folder { get; set; }

        public CurrentFolder(Folder? initialFolder = null)
        {
            Folder = initialFolder;
        }

    }
}
