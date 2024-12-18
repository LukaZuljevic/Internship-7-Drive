using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Drive.Data.Entities;

namespace Drive.Domain.Factories
{
    public static class DbContextFactory
    {
        public static DumpDriveDbContext GetDriveDbContext()
        {
            var options = new DbContextOptionsBuilder()
                .UseNpgsql(ConfigurationManager.ConnectionStrings["Drive"].ConnectionString)
                .Options;

            return new DumpDriveDbContext(options);
        }
    }
}
