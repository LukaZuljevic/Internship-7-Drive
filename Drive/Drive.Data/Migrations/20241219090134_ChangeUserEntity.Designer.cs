﻿// <auto-generated />
using System;
using Drive.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Drive.Data.Migrations
{
    [DbContext(typeof(DumpDriveDbContext))]
    [Migration("20241219090134_ChangeUserEntity")]
    partial class ChangeUserEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Drive.Data.Entities.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CommentId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("CommentId");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            Content = "Komentar 1",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6976),
                            ItemId = 1,
                            UserId = 1
                        },
                        new
                        {
                            CommentId = 2,
                            Content = "Komentar 2",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7492),
                            ItemId = 2,
                            UserId = 1
                        },
                        new
                        {
                            CommentId = 3,
                            Content = "Komentar 3",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7493),
                            ItemId = 3,
                            UserId = 1
                        },
                        new
                        {
                            CommentId = 4,
                            Content = "Komentar 4",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7494),
                            ItemId = 4,
                            UserId = 6
                        },
                        new
                        {
                            CommentId = 5,
                            Content = "Komentar 5",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7495),
                            ItemId = 5,
                            UserId = 3
                        },
                        new
                        {
                            CommentId = 6,
                            Content = "Komentar 6",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7497),
                            ItemId = 6,
                            UserId = 2
                        },
                        new
                        {
                            CommentId = 7,
                            Content = "Komentar 7",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7498),
                            ItemId = 7,
                            UserId = 5
                        },
                        new
                        {
                            CommentId = 8,
                            Content = "Komentar 8",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7499),
                            ItemId = 8,
                            UserId = 3
                        },
                        new
                        {
                            CommentId = 9,
                            Content = "Komentar 9",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7500),
                            ItemId = 9,
                            UserId = 2
                        },
                        new
                        {
                            CommentId = 10,
                            Content = "Komentar 10",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7501),
                            ItemId = 10,
                            UserId = 7
                        },
                        new
                        {
                            CommentId = 11,
                            Content = "Komentar 11",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7502),
                            ItemId = 11,
                            UserId = 3
                        },
                        new
                        {
                            CommentId = 12,
                            Content = "Komentar 12",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7503),
                            ItemId = 12,
                            UserId = 2
                        },
                        new
                        {
                            CommentId = 13,
                            Content = "Komentar 13",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7503),
                            ItemId = 13,
                            UserId = 1
                        },
                        new
                        {
                            CommentId = 14,
                            Content = "Komentar 14",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7504),
                            ItemId = 14,
                            UserId = 6
                        },
                        new
                        {
                            CommentId = 15,
                            Content = "Komentar 15",
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(7505),
                            ItemId = 13,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Disk", b =>
                {
                    b.Property<int>("DiskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DiskId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("DiskId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Disks");

                    b.HasData(
                        new
                        {
                            DiskId = 1,
                            Name = "Lukin-disk",
                            UserId = 1
                        },
                        new
                        {
                            DiskId = 2,
                            Name = "Antin-disk",
                            UserId = 2
                        },
                        new
                        {
                            DiskId = 3,
                            Name = "Matin-disk",
                            UserId = 3
                        },
                        new
                        {
                            DiskId = 4,
                            Name = "Stipin-disk",
                            UserId = 4
                        },
                        new
                        {
                            DiskId = 5,
                            Name = "Mijin-disk",
                            UserId = 5
                        },
                        new
                        {
                            DiskId = 6,
                            Name = "Rokov-disk",
                            UserId = 6
                        },
                        new
                        {
                            DiskId = 7,
                            Name = "Jozin-disk",
                            UserId = 7
                        });
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ItemId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DiskId")
                        .HasColumnType("integer");

                    b.Property<string>("Item_type")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.Property<DateTime?>("LastChangedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ParentFolderId")
                        .HasColumnType("integer");

                    b.HasKey("ItemId");

                    b.HasIndex("DiskId");

                    b.ToTable("Items");

                    b.HasDiscriminator<string>("Item_type").HasValue("Item");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.SharedItem", b =>
                {
                    b.Property<int>("SharedItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SharedItemId"));

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("SharedItemId");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("SharedItems");
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DiskId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 44, DateTimeKind.Utc).AddTicks(8969),
                            DiskId = 1,
                            Email = "luka.zuljo@gmail.com",
                            Password = "password"
                        },
                        new
                        {
                            UserId = 2,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 44, DateTimeKind.Utc).AddTicks(9878),
                            DiskId = 2,
                            Email = "ante.antic@gmail.com",
                            Password = "password"
                        },
                        new
                        {
                            UserId = 3,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 44, DateTimeKind.Utc).AddTicks(9882),
                            DiskId = 3,
                            Email = "mate.matic@gmail.com",
                            Password = "password"
                        },
                        new
                        {
                            UserId = 4,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 44, DateTimeKind.Utc).AddTicks(9883),
                            DiskId = 4,
                            Email = "stipe.stipic@gmail.com",
                            Password = "password"
                        },
                        new
                        {
                            UserId = 5,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 44, DateTimeKind.Utc).AddTicks(9898),
                            DiskId = 5,
                            Email = "mijo.mijic@gmail.com",
                            Password = "password"
                        },
                        new
                        {
                            UserId = 6,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 44, DateTimeKind.Utc).AddTicks(9901),
                            DiskId = 6,
                            Email = "roko.rokic@gmail.com",
                            Password = "password"
                        },
                        new
                        {
                            UserId = 7,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 44, DateTimeKind.Utc).AddTicks(9902),
                            DiskId = 7,
                            Email = "jozo.jozic@gmail.com",
                            Password = "password"
                        });
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Files", b =>
                {
                    b.HasBaseType("Drive.Data.Entities.Models.Item");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasIndex("ParentFolderId");

                    b.HasDiscriminator().HasValue("File");
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Folder", b =>
                {
                    b.HasBaseType("Drive.Data.Entities.Models.Item");

                    b.HasIndex("ParentFolderId");

                    b.HasDiscriminator().HasValue("Folder");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(5642),
                            DiskId = 1,
                            Name = "Dump-domaci"
                        },
                        new
                        {
                            ItemId = 2,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6148),
                            DiskId = 1,
                            Name = "Fesb-predavanja"
                        },
                        new
                        {
                            ItemId = 3,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6151),
                            DiskId = 1,
                            Name = "Web-programiranje",
                            ParentFolderId = 2
                        },
                        new
                        {
                            ItemId = 4,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6298),
                            DiskId = 2,
                            Name = "Recepti"
                        },
                        new
                        {
                            ItemId = 5,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6300),
                            DiskId = 2,
                            Name = "Sve-I-Svasta"
                        },
                        new
                        {
                            ItemId = 6,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6305),
                            DiskId = 3,
                            Name = "Operacijski-sustavi"
                        },
                        new
                        {
                            ItemId = 7,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6306),
                            DiskId = 3,
                            Name = "Linux",
                            ParentFolderId = 6
                        },
                        new
                        {
                            ItemId = 8,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6307),
                            DiskId = 3,
                            Name = "Windows",
                            ParentFolderId = 6
                        },
                        new
                        {
                            ItemId = 9,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6308),
                            DiskId = 4,
                            Name = "Slike"
                        },
                        new
                        {
                            ItemId = 10,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6310),
                            DiskId = 4,
                            Name = "Dokumenti"
                        },
                        new
                        {
                            ItemId = 11,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6311),
                            DiskId = 5,
                            Name = "Projekti"
                        },
                        new
                        {
                            ItemId = 12,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6311),
                            DiskId = 5,
                            Name = "Zavrsni-rad",
                            ParentFolderId = 11
                        },
                        new
                        {
                            ItemId = 13,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6312),
                            DiskId = 5,
                            Name = "Projektni-zadaci",
                            ParentFolderId = 11
                        },
                        new
                        {
                            ItemId = 14,
                            CreatedAt = new DateTime(2024, 12, 19, 9, 1, 34, 45, DateTimeKind.Utc).AddTicks(6314),
                            DiskId = 6,
                            Name = "Folder-za-faks"
                        });
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Comment", b =>
                {
                    b.HasOne("Drive.Data.Entities.Models.Item", "Item")
                        .WithMany("Comments")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Drive.Data.Entities.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Disk", b =>
                {
                    b.HasOne("Drive.Data.Entities.Models.User", "User")
                        .WithOne("Disk")
                        .HasForeignKey("Drive.Data.Entities.Models.Disk", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Item", b =>
                {
                    b.HasOne("Drive.Data.Entities.Models.Disk", "Disk")
                        .WithMany("Items")
                        .HasForeignKey("DiskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disk");
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.SharedItem", b =>
                {
                    b.HasOne("Drive.Data.Entities.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Drive.Data.Entities.Models.User", "User")
                        .WithMany("SharedItems")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Files", b =>
                {
                    b.HasOne("Drive.Data.Entities.Models.Folder", "ParentFolder")
                        .WithMany("Files")
                        .HasForeignKey("ParentFolderId");

                    b.Navigation("ParentFolder");
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Folder", b =>
                {
                    b.HasOne("Drive.Data.Entities.Models.Folder", "ParentFolder")
                        .WithMany()
                        .HasForeignKey("ParentFolderId");

                    b.Navigation("ParentFolder");
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Disk", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Item", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Disk")
                        .IsRequired();

                    b.Navigation("SharedItems");
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Folder", b =>
                {
                    b.Navigation("Files");
                });
#pragma warning restore 612, 618
        }
    }
}
