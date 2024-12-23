using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Drive.Data.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "DiskId", "Email", "Password" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(497), 1, "luka.zuljo@gmail.com", "password" },
                    { 2, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(1561), 2, "ante.antic@gmail.com", "password" },
                    { 3, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(1565), 3, "mate.matic@gmail.com", "password" },
                    { 4, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(1566), 4, "stipe.stipic@gmail.com", "password" },
                    { 5, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(1568), 5, "mijo.mijic@gmail.com", "password" },
                    { 6, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(1572), 6, "roko.rokic@gmail.com", "password" },
                    { 7, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(1573), 7, "jozo.jozic@gmail.com", "password" }
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
                columns: new[] { "ItemId", "CreatedAt", "DiskId", "Item_type", "LastChangedAt", "Name", "ParentFolderId", "ParentFolderItemId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7116), 1, "Folder", null, "Dump-domaci", null, null },
                    { 2, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7543), 1, "Folder", null, "Fesb-predavanja", null, null },
                    { 4, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7696), 2, "Folder", null, "Recepti", null, null },
                    { 5, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7697), 2, "Folder", null, "Sve-I-Svasta", null, null },
                    { 6, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7701), 3, "Folder", null, "Operacijski-sustavi", null, null },
                    { 9, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7737), 4, "Folder", null, "Slike", null, null },
                    { 10, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7739), 4, "Folder", null, "Dokumenti", null, null },
                    { 11, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7740), 5, "Folder", null, "Projekti", null, null },
                    { 14, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7743), 6, "Folder", null, "Folder-za-faks", null, null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Content", "CreatedAt", "ItemId", "UserId" },
                values: new object[,]
                {
                    { 1, "Komentar 1", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9243), 1, 1 },
                    { 2, "Komentar 2", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9774), 2, 1 },
                    { 4, "Komentar 4", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9776), 4, 6 },
                    { 5, "Komentar 5", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9777), 5, 3 },
                    { 6, "Komentar 6", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9780), 6, 2 },
                    { 9, "Komentar 9", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9783), 9, 2 },
                    { 10, "Komentar 10", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9784), 10, 7 },
                    { 11, "Komentar 11", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9785), 11, 3 },
                    { 14, "Komentar 14", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9787), 14, 6 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CreatedAt", "DiskId", "Item_type", "LastChangedAt", "Name", "ParentFolderId", "ParentFolderItemId" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7545), 1, "Folder", null, "Web-programiranje", 2, null },
                    { 7, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7734), 3, "Folder", null, "Linux", 6, null },
                    { 8, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7736), 3, "Folder", null, "Windows", 6, null },
                    { 12, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7741), 5, "Folder", null, "Zavrsni-rad", 11, null },
                    { 13, new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(7742), 5, "Folder", null, "Projektni-zadaci", 11, null }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Content", "CreatedAt", "DiskId", "Item_type", "LastChangedAt", "Name", "ParentFolderId", "ParentFolderItemId" },
                values: new object[,]
                {
                    { 15, "Content for Dump Domaci Notes", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(8482), 1, "File", null, "Dump Domaci.docx", 1, null },
                    { 16, "Content for Fesb Predavanja Slides", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(8676), 1, "File", null, "Fesb Predavanja.txt", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Content", "CreatedAt", "ItemId", "UserId" },
                values: new object[,]
                {
                    { 3, "Komentar 3", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9775), 3, 1 },
                    { 7, "Komentar 7", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9781), 7, 5 },
                    { 8, "Komentar 8", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9782), 8, 3 },
                    { 12, "Komentar 12", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9786), 12, 2 },
                    { 13, "Komentar 13", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9786), 13, 1 },
                    { 15, "Komentar 15", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(9788), 13, 3 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Content", "CreatedAt", "DiskId", "Item_type", "LastChangedAt", "Name", "ParentFolderId", "ParentFolderItemId" },
                values: new object[] { 17, "Content for Web Programiranje Code", new DateTime(2024, 12, 23, 16, 29, 21, 297, DateTimeKind.Utc).AddTicks(8678), 1, "File", null, "Web Programiranje.pdf", 3, null });
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
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17);

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
