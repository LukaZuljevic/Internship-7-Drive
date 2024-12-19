using Drive.Data.Entities.Models;
using Drive.Data.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;

namespace Drive.Data.Entities
{
    public class DumpDriveDbContext : DbContext
    {
        public DumpDriveDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Disk> Disks => Set<Disk>();
        public DbSet<Item> Items => Set<Item>();
        public DbSet<Folder> Folders => Set<Folder>();
        public DbSet<Files> Files => Set<Files>();
        public DbSet<SharedItem> SharedItems => Set<SharedItem>();
        public DbSet<Comment> Comments => Set<Comment>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
               .HasDiscriminator<string>("Item_type")
               .HasValue<Folder>("Folder")
               .HasValue<Files>("File");

            modelBuilder.Entity<User>()
                .HasOne(u => u.Disk)
                .WithOne(d => d.User)
                .HasForeignKey<Disk>(d => d.UserId);

            modelBuilder.Entity<Disk>()
                .HasMany(d => d.Items)
                .WithOne(i => i.Disk)
                .HasForeignKey(i => i.DiskId);

            modelBuilder.Entity<SharedItem>()
                .HasOne(s => s.Item)
                .WithMany()
                .HasForeignKey(s => s.ItemId);

            modelBuilder.Entity<SharedItem>()
                .HasOne(s => s.User)
                .WithMany(u => u.SharedItems)
                .HasForeignKey(s => s.UserId);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Item)
                .WithMany(i => i.Comments)
                .HasForeignKey(c => c.ItemId);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId);

            DriveDbSeeder.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                   warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
    }

    public class DriveDbContextFactory : IDesignTimeDbContextFactory<DumpDriveDbContext>
    {
        public DumpDriveDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddXmlFile("App.config")
                .Build();

            config.Providers
                .First()
                .TryGet("connectionStrings:add:Drive:connectionString", out var connectionString);

            var options = new DbContextOptionsBuilder<DumpDriveDbContext>()
                .UseNpgsql(connectionString)
                .Options;

            return new DumpDriveDbContext(options);
        }
    }
}