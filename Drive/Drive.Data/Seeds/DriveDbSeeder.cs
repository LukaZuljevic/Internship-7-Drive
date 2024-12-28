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
                    new User("luka@gmail.com", "12345")
                    {
                        UserId = 1,
                        DiskId = 1
                    },

                    new User("ante@gmail.com", "12345")
                    {
                        UserId = 2,
                        DiskId = 2
                    },

                    new User("mate@gmail.com", "12345")
                    {
                        UserId = 3,
                        DiskId = 3
                    },
                });

            builder.Entity<Disk>()
                .HasData(new List<Disk> 
                {
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
                });

            builder.Entity<Folder>()
                .HasData(new List<Folder>
                {
                    
                    new Folder("Fesb-predavanja")
                    {
                        ItemId = 2,
                        DiskId = 1
                    },

                    new Folder("Web-prog")
                    {
                        ItemId = 3,
                        ParentFolderId = 2,
                        DiskId = 1
                    },

                    new Folder("Slike")
                    {
                        ItemId = 4,
                        DiskId = 1
                    },

                    new Folder("Moje slike")
                    { 
                        ItemId = 1,
                        ParentFolderId = 4,
                        DiskId = 1
                    },

                    new Folder("Dokumenti")
                    {
                        ItemId = 5,
                        DiskId = 1
                    },

                    new Folder("Projektni-zadaci")
                    {
                        ItemId = 6,
                        ParentFolderId = 2,
                        DiskId = 1
                    },

                    new Folder("Recepti")
                    {
                        ItemId = 7,
                        DiskId = 2
                    },

                    new Folder("Svasta")
                    {
                        ItemId = 8,
                        DiskId = 2
                    },
                          
                    new Folder("Projekti")
                    {
                        ItemId = 9,
                        DiskId = 2
                    },

                    new Folder("Zavrsni-rad")
                    {
                        ItemId = 10,
                        ParentFolderId = 9,
                        DiskId = 2
                    },

                    new Folder("Operacijski-sustavi")
                    {
                        ItemId = 11,
                        DiskId = 3
                    },

                    new Folder("Linux")
                    {
                        ItemId = 12,
                        ParentFolderId = 11,
                        DiskId = 3
                    },

                    new Folder("Windows")
                    {
                        ItemId = 13,
                        ParentFolderId = 11,
                        DiskId = 3
                    },

                    new Folder("Folder-za-faks")
                    {
                        ItemId = 14,
                        DiskId = 3
                    },
                });

            builder.Entity<Files>()
               .HasData(new List<Files>
               {
                    new Files("domaci.docx", "Content for Dump Domaci Notes")
                    {
                        ItemId = 15,
                        DiskId = 1,
                        ParentFolderId = 1,
                    },
                    new Files("predavanje.txt", "Content for Fesb Predavanja Slides")
                    {
                        ItemId = 16,
                        DiskId = 1,
                        ParentFolderId = 2,
                    },
                    new Files("preza.pdf", "Content for Web Programiranje Code")
                    {
                        ItemId = 17,
                        DiskId = 1,
                        ParentFolderId = 3,
                    },

                    new Files("osobni-dokument.docx", "Content for Personal Documents")
                    {
                        ItemId = 18,
                        DiskId = 1,
                        ParentFolderId = 5,
                    },

                    new Files("Review.txt", "Review")
                    {
                        ItemId = 19,
                        DiskId = 1,
                    },

                    new Files("Recepti.docx", "Content for Recepti")
                    {
                        ItemId = 20,
                        DiskId = 1,
                    },

                     new Files("notes.txt", "Class notes")
                    {
                        ItemId = 21,
                        DiskId = 1,
                        ParentFolderId = 2,
                    },
                    new Files("summary.pdf", "Project summary")
                    {
                        ItemId = 22,
                        DiskId = 1,
                        ParentFolderId = 6,
                    },
                    new Files("picture-description.txt", "A random picture")
                    {
                        ItemId = 23,
                        DiskId = 1,
                        ParentFolderId = 4,
                    },
                    new Files("tasklist.docx", "List of tasks")
                    {
                        ItemId = 24,
                        DiskId = 1,
                        ParentFolderId = 9,
                    },
                    new Files("thesis.docx", "Thesis draft")
                    {
                        ItemId = 25,
                        DiskId = 2,
                        ParentFolderId = 10,
                    },
                    new Files("system-notes.txt", "Notes on OS")
                    {
                        ItemId = 26,
                        DiskId = 3,
                        ParentFolderId = 11,
                    },
                    new Files("linux-guide.pdf", "Linux guide")
                    {
                        ItemId = 27,
                        DiskId = 3,
                        ParentFolderId = 12,
                    },
                    new Files("windows-faq.docx", "Windows FAQ")
                    {
                        ItemId = 28,
                        DiskId = 3,
                        ParentFolderId = 13,
                    },
                    new Files("study-plan.txt", "Plan for studying")
                    {
                        ItemId = 29,
                        DiskId = 3,
                        ParentFolderId = 14,
                    }
                      });

               

                        builder.Entity<Comment>()
                .HasData(new List<Comment>
                {
                    new Comment("Komentar 1")
                    {
                        CommentId = 1,
                        UserId = 1,
                        ItemId = 15
                    },

                    new Comment("Komentar 2")
                    {
                        CommentId = 2,
                        UserId = 1,
                        ItemId = 16
                    },

                    new Comment("Komentar 3")
                    {
                        CommentId = 3,
                        UserId = 1,
                        ItemId = 17
                    },

                    new Comment("Komentar 4")
                    {
                        CommentId = 4,
                        UserId = 2,
                        ItemId = 18
                    },

                    new Comment("Komentar 5")
                    {
                        CommentId = 5,
                        UserId = 3,
                        ItemId = 19
                    },

                    new Comment("Komentar 6")
                    {
                        CommentId = 6,
                        UserId = 2,
                        ItemId = 20
                    },

                    new Comment("Komentar 7")
                    {
                        CommentId = 7,
                        UserId = 1,
                        ItemId = 21
                    },

                    new Comment("Komentar 8")
                    {
                        CommentId = 8,
                        UserId = 3,
                        ItemId = 22
                    },

                    new Comment("Komentar 9")
                    {
                        CommentId = 9,
                        UserId = 2,
                        ItemId = 23
                    },

                    new Comment("Komentar 10")
                    {
                        CommentId = 10,
                        UserId = 1,
                        ItemId = 24
                    },

                    new Comment("Komentar 11")
                    {
                        CommentId = 11,
                        UserId = 3,
                        ItemId = 25
                    },

                    new Comment("Komentar 12")
                    {
                        CommentId = 12,
                        UserId = 2,
                        ItemId = 26
                    },

                    new Comment("Komentar 13")
                    {
                        CommentId = 13,
                        UserId = 1,
                        ItemId = 27
                    },

                    new Comment("Komentar 14")
                    {
                        CommentId = 14,
                        UserId = 2,
                        ItemId = 28
                    },

                    new Comment("Komentar 15")
                    {
                        CommentId = 15,
                        UserId = 3,
                        ItemId = 29
                    },

                    new Comment("Komentar 16")
                    {
                        CommentId = 16,
                        UserId = 1,
                        ItemId = 15
                    },

                    new Comment("Komentar 17")
                    {
                        CommentId = 17,
                        UserId = 2,
                        ItemId = 16
                    },

                    new Comment("Komentar 18")
                    {
                        CommentId = 18,
                        UserId = 3,
                        ItemId = 17
                    },

                    new Comment("Komentar 19")
                    {
                        CommentId = 19,
                        UserId = 1,
                        ItemId = 18
                    },

                    new Comment("Komentar 20")
                    {
                        CommentId = 20,
                        UserId = 2,
                        ItemId = 19
                    },

                    new Comment("Komentar 21")
                    {
                        CommentId = 21,
                        UserId = 3,
                        ItemId = 20
                    },

                    new Comment("Komentar 22")
                    {
                        CommentId = 22,
                        UserId = 1,
                        ItemId = 21
                    },

                    new Comment("Komentar 23")
                    {
                        CommentId = 23,
                        UserId = 2,
                        ItemId = 22
                    },

                    new Comment("Komentar 24")
                    {
                        CommentId = 24,
                        UserId = 3,
                        ItemId = 23
                    },

                    new Comment("Komentar 25")
                    {
                        CommentId = 25,
                        UserId = 1,
                        ItemId = 24
                    },

                    new Comment("Komentar 26")
                    {
                        CommentId = 26,
                        UserId = 2,
                        ItemId = 25
                    },

                    new Comment("Komentar 27")
                    {
                        CommentId = 27,
                        UserId = 3,
                        ItemId = 26
                    },

                    new Comment("Komentar 28")
                    {
                        CommentId = 28,
                        UserId = 1,
                        ItemId = 27
                    },

                    new Comment("Komentar 29")
                    {
                        CommentId = 29,
                        UserId = 2,
                        ItemId = 28
                    },

                    new Comment("Komentar 30")
                    {
                        CommentId = 30,
                        UserId = 3,
                        ItemId = 29
                    }
                });

                     builder.Entity<SharedItem>()
                    .HasData(new List<SharedItem>
                    {
                    new SharedItem(15, 1, "domaci.docx")
                    {
                        SharedItemId = 1
                    },
                    new SharedItem(16, 2, "predavanje.txt")
                    {
                        SharedItemId = 2
                    },
                    new SharedItem(17, 3, "preza.pdf")
                    {
                        SharedItemId = 3
                    },
                    new SharedItem(18, 1, "osobni-dokument.docx")
                    {
                        SharedItemId = 4
                    },
                    new SharedItem(19, 2, "Review.txt")
                    {
                        SharedItemId = 5
                    },
                    new SharedItem(20, 3, "Recepti.docx")
                    {
                        SharedItemId = 6
                    },
                    new SharedItem(21, 1, "notes.txt")
                    {
                        SharedItemId = 7
                    },
                    new SharedItem(22, 2, "summary.pdf")
                    {
                        SharedItemId = 8
                    },
                    new SharedItem(23, 3, "picture.jpg")
                    {
                        SharedItemId = 9
                    },
                    new SharedItem(24, 1, "tasklist.docx")
                    {
                        SharedItemId = 10
                    }
                    });
        }
    }
}
