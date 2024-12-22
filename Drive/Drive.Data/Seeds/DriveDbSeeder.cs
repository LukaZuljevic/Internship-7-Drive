using Microsoft.EntityFrameworkCore;
using Drive.Data.Entities.Models;

namespace Drive.Data.Seeds
{
    public static class DriveDbSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(new List<User>
                {
                    new User("luka.zuljo@gmail.com", "password")
                    {
                        UserId = 1,
                        DiskId = 1
                    },

                    new User("ante.antic@gmail.com", "password")
                    {
                        UserId = 2,
                        DiskId = 2
                    },

                    new User("mate.matic@gmail.com", "password")
                    {
                        UserId = 3,
                        DiskId = 3
                    },

                    new User("stipe.stipic@gmail.com", "password")
                    {
                        UserId = 4,
                        DiskId = 4
                    },

                    new User("mijo.mijic@gmail.com", "password")
                    {
                        UserId = 5,
                        DiskId = 5
                    },

                    new User("roko.rokic@gmail.com", "password")
                    {
                        UserId = 6,
                        DiskId = 6
                    },

                    new User("jozo.jozic@gmail.com", "password")
                    {
                        UserId = 7,
                        DiskId = 7
                    },
                });

            builder.Entity<Disk>()
                .HasData(new List<Disk> {
                    new Disk("Lukin-disk")
                    {
                        DiskId = 1,
                        UserId = 1
                    },

                    new Disk("Antin-disk")
                    {
                        DiskId = 2,
                        UserId = 2
                    },

                    new Disk("Matin-disk")
                    {
                        DiskId = 3,
                        UserId = 3
                    },

                    new Disk("Stipin-disk")
                    {
                        DiskId = 4,
                        UserId = 4
                    },

                    new Disk("Mijin-disk")
                    {
                        DiskId = 5,
                        UserId = 5
                    },

                    new Disk("Rokov-disk")
                    {
                        DiskId = 6,
                        UserId = 6
                    },

                    new Disk("Jozin-disk")
                    {
                        DiskId = 7,
                        UserId = 7
                    },
                });

            builder.Entity<Folder>()
                .HasData(new List<Folder>
                {
                    new Folder("Dump-domaci")
                    {
                        ItemId = 1,
                        DiskId = 1
                    },

                    new Folder("Fesb-predavanja")
                    {
                        ItemId = 2,
                        DiskId = 1
                    },

                    new Folder("Web-programiranje")
                    {
                        ItemId = 3,
                        ParentFolderId = 2,
                        DiskId = 1
                    },

                    new Folder("Recepti")
                    {
                        ItemId = 4,
                        DiskId = 2
                    },

                    new Folder("Sve-I-Svasta")
                    {
                        ItemId = 5,
                        DiskId = 2
                    },

                    new Folder("Operacijski-sustavi")
                    {
                        ItemId = 6,
                        DiskId = 3
                    },

                    new Folder("Linux")
                    {
                        ItemId = 7,
                        ParentFolderId = 6,
                        DiskId = 3
                    },

                    new Folder("Windows")
                    {
                        ItemId = 8,
                        ParentFolderId = 6,
                        DiskId = 3
                    },

                    new Folder("Slike")
                    {
                        ItemId = 9,
                        DiskId = 4
                    },

                    new Folder("Dokumenti")
                    {
                        ItemId = 10,
                        DiskId = 4
                    },

                    new Folder("Projekti")
                    {
                        ItemId = 11,
                        DiskId = 5
                    },

                    new Folder("Zavrsni-rad")
                    {
                        ItemId = 12,
                        ParentFolderId = 11,
                        DiskId = 5
                    },

                    new Folder("Projektni-zadaci")
                    {
                        ItemId = 13,
                        ParentFolderId = 11,
                        DiskId = 5
                    },

                    new Folder("Folder-za-faks")
                    {
                        ItemId = 14,
                        DiskId = 6
                    },
                });

            builder.Entity<Files>()
               .HasData(new List<Files>
               {
                    new Files("Dump Domaci.docx", "Content for Dump Domaci Notes")
                    {
                        ItemId = 15,
                        DiskId = 1,
                        ParentFolderId = 1, 
                    },
                    new Files("Fesb Predavanja.txt", "Content for Fesb Predavanja Slides")
                    {
                        ItemId = 16,
                        DiskId = 1,
                        ParentFolderId = 2, 
                    },
                    new Files("Web Programiranje.pdf", "Content for Web Programiranje Code")
                    {
                        ItemId = 17,
                        DiskId = 1,
                        ParentFolderId = 3,
                    },
               });

            builder.Entity<Comment>()
                .HasData(new List<Comment>
                {
                    new Comment("Komentar 1")
                    {
                        CommentId = 1,
                        UserId = 1,
                        ItemId = 1
                    },

                    new Comment("Komentar 2")
                    {
                        CommentId = 2,
                        UserId = 1,
                        ItemId = 2
                    },

                    new Comment("Komentar 3")
                    {
                        CommentId = 3,
                        UserId = 1,
                        ItemId = 3
                    },

                    new Comment("Komentar 4")
                    {
                        CommentId = 4,
                        UserId = 6,
                        ItemId = 4
                    },

                    new Comment("Komentar 5")
                    {
                        CommentId = 5,
                        UserId = 3,
                        ItemId = 5
                    },

                    new Comment("Komentar 6")
                    {
                        CommentId = 6,
                        UserId = 2,
                        ItemId = 6
                    },

                    new Comment("Komentar 7")
                    {
                        CommentId = 7,
                        UserId = 5,
                        ItemId = 7
                    },

                    new Comment("Komentar 8")
                    {
                        CommentId = 8,
                        UserId = 3,
                        ItemId = 8
                    },

                    new Comment("Komentar 9")
                    {
                        CommentId = 9,
                        UserId = 2,
                        ItemId = 9
                    },

                    new Comment("Komentar 10")
                    {
                        CommentId = 10,
                        UserId = 7,
                        ItemId = 10
                    },

                    new Comment("Komentar 11")
                    {
                        CommentId = 11,
                        UserId = 3,
                        ItemId = 11
                    },

                    new Comment("Komentar 12")
                    {
                        CommentId = 12,
                        UserId = 2,
                        ItemId = 12
                    },

                    new Comment("Komentar 13")
                    {
                        CommentId = 13,
                        UserId = 1,
                        ItemId = 13
                    },

                    new Comment("Komentar 14")
                    {
                        CommentId = 14,
                        UserId = 6,
                        ItemId = 14
                    },

                    new Comment("Komentar 15")
                    {
                        CommentId = 15,
                        UserId = 3,
                        ItemId = 13
                    },
                });
        }
    }
}
