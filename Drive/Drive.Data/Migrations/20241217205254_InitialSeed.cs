using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Drive.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "DiskId", "Email", "Password" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 17, 20, 52, 54, 368, DateTimeKind.Utc).AddTicks(3929), 0, "luka.zuljo@gmail.com", "password" },
                    { 2, new DateTime(2024, 12, 17, 20, 52, 54, 368, DateTimeKind.Utc).AddTicks(4599), 0, "ante.antic@gmail.com", "password" },
                    { 3, new DateTime(2024, 12, 17, 20, 52, 54, 368, DateTimeKind.Utc).AddTicks(4602), 0, "mate.matic@gmail.com", "password" },
                    { 4, new DateTime(2024, 12, 17, 20, 52, 54, 368, DateTimeKind.Utc).AddTicks(4603), 0, "stipe.stipic@gmail.com", "password" },
                    { 5, new DateTime(2024, 12, 17, 20, 52, 54, 368, DateTimeKind.Utc).AddTicks(4618), 0, "mijo.mijic@gmail.com", "password" },
                    { 6, new DateTime(2024, 12, 17, 20, 52, 54, 368, DateTimeKind.Utc).AddTicks(4621), 0, "roko.rokic@gmail.com", "password" },
                    { 7, new DateTime(2024, 12, 17, 20, 52, 54, 368, DateTimeKind.Utc).AddTicks(4622), 0, "jozo.jozic@gmail.com", "password" }
                });

            migrationBuilder.InsertData(
                table: "Disks",
                columns: new[] { "DiskId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "Lukin-disk", 1 },
                    { 2, "Antin-disk", 2 },
                    { 3, "Matin-disk", 3 },
                    { 4, "Stipin-disk", 4 },
                    { 5, "Mijin-disk", 5 },
                    { 6, "Rokov-disk", 6 },
                    { 7, "Jozin-disk", 7 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CreatedAt", "DiskId", "Item_type", "LastChangedAt", "Name", "ParentFolderId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(543), 1, "Folder", null, "Dump-domaci", null },
                    { 2, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(995), 1, "Folder", null, "Fesb-predavanja", null },
                    { 4, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(1218), 2, "Folder", null, "Recepti", null },
                    { 5, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(1220), 2, "Folder", null, "Sve-I-Svasta", null },
                    { 6, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(1225), 3, "Folder", null, "Operacijski-sustavi", null },
                    { 9, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(1228), 4, "Folder", null, "Slike", null },
                    { 10, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(1230), 4, "Folder", null, "Dokumenti", null },
                    { 11, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(1231), 5, "Folder", null, "Projekti", null },
                    { 14, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(1234), 6, "Folder", null, "Folder-za-faks", null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Content", "CreatedAt", "ItemId", "UserId" },
                values: new object[,]
                {
                    { 1, "Komentar 1", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(1872), 1, 1 },
                    { 2, "Komentar 2", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2411), 2, 1 },
                    { 4, "Komentar 4", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2413), 4, 6 },
                    { 5, "Komentar 5", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2414), 5, 3 },
                    { 6, "Komentar 6", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2416), 6, 2 },
                    { 9, "Komentar 9", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2419), 9, 2 },
                    { 10, "Komentar 10", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2420), 10, 7 },
                    { 11, "Komentar 11", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2421), 11, 3 },
                    { 14, "Komentar 14", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2423), 14, 6 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CreatedAt", "DiskId", "Item_type", "LastChangedAt", "Name", "ParentFolderId" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(997), 1, "Folder", null, "Web-programiranje", 2 },
                    { 7, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(1226), 3, "Folder", null, "Linux", 6 },
                    { 8, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(1227), 3, "Folder", null, "Windows", 6 },
                    { 12, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(1232), 5, "Folder", null, "Zavrsni-rad", 11 },
                    { 13, new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(1233), 5, "Folder", null, "Projektni-zadaci", 11 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Content", "CreatedAt", "ItemId", "UserId" },
                values: new object[,]
                {
                    { 3, "Komentar 3", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2412), 3, 1 },
                    { 7, "Komentar 7", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2417), 7, 5 },
                    { 8, "Komentar 8", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2418), 8, 3 },
                    { 12, "Komentar 12", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2421), 12, 2 },
                    { 13, "Komentar 13", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2422), 13, 1 },
                    { 15, "Komentar 15", new DateTime(2024, 12, 17, 20, 52, 54, 369, DateTimeKind.Utc).AddTicks(2424), 13, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Disks",
                keyColumn: "DiskId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Disks",
                keyColumn: "DiskId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Disks",
                keyColumn: "DiskId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Disks",
                keyColumn: "DiskId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Disks",
                keyColumn: "DiskId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Disks",
                keyColumn: "DiskId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Disks",
                keyColumn: "DiskId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);
        }
    }
}
