﻿namespace Drive.Data.Entities.Models
{
    public class Disk
    {
        public Disk(string name)
        {
            Name = name;
        }

        public int DiskId { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public User User { get; set; } = null!;

        public List<Item> Items { get; set; } = new List<Item>();
    }
}