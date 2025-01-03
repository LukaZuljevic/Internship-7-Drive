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
    [Migration("20241228144529_InitialMigration")]
    partial class InitialMigration
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

                    b.Property<int?>("ParentFolderItemId")
                        .HasColumnType("integer");

                    b.HasKey("ItemId");

                    b.HasIndex("DiskId");

                    b.HasIndex("ParentFolderId");

                    b.HasIndex("ParentFolderItemId");

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

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("text");

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
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Files", b =>
                {
                    b.HasBaseType("Drive.Data.Entities.Models.Item");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("File");
                });

            modelBuilder.Entity("Drive.Data.Entities.Models.Folder", b =>
                {
                    b.HasBaseType("Drive.Data.Entities.Models.Item");

                    b.HasDiscriminator().HasValue("Folder");
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

                    b.HasOne("Drive.Data.Entities.Models.Folder", null)
                        .WithMany("Items")
                        .HasForeignKey("ParentFolderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Drive.Data.Entities.Models.Folder", "ParentFolder")
                        .WithMany()
                        .HasForeignKey("ParentFolderItemId");

                    b.Navigation("Disk");

                    b.Navigation("ParentFolder");
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
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
