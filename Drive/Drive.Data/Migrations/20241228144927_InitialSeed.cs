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
                    { 1, new DateTime(2024, 12, 28, 14, 49, 26, 607, DateTimeKind.Utc).AddTicks(3483), 1, "luka@gmail.com", "12345" },
                    { 2, new DateTime(2024, 12, 28, 14, 49, 26, 607, DateTimeKind.Utc).AddTicks(4204), 2, "ante@gmail.com", "12345" },
                    { 3, new DateTime(2024, 12, 28, 14, 49, 26, 607, DateTimeKind.Utc).AddTicks(4207), 3, "mate@gmail.com", "12345" }
                });

            migrationBuilder.InsertData(
                table: "Disks",
                columns: new[] { "DiskId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "Lukin-disk", 1 },
                    { 2, "Antin-disk", 2 },
                    { 3, "Matin-disk", 3 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CreatedAt", "DiskId", "Item_type", "LastChangedAt", "Name", "ParentFolderId", "ParentFolderItemId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(96), 1, "Folder", null, "Fesb-predavanja", null, null },
                    { 4, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(680), 1, "Folder", null, "Slike", null, null },
                    { 5, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(683), 1, "Folder", null, "Dokumenti", null, null },
                    { 7, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(690), 2, "Folder", null, "Recepti", null, null },
                    { 8, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(691), 2, "Folder", null, "Svasta", null, null },
                    { 9, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(692), 2, "Folder", null, "Projekti", null, null },
                    { 11, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(694), 3, "Folder", null, "Operacijski-sustavi", null, null },
                    { 14, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(697), 3, "Folder", null, "Folder-za-faks", null, null }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Content", "CreatedAt", "DiskId", "Item_type", "LastChangedAt", "Name", "ParentFolderId", "ParentFolderItemId" },
                values: new object[,]
                {
                    { 19, "Review", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1626), 1, "File", null, "Review.txt", null, null },
                    { 20, "Content for Recepti", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1628), 1, "File", null, "Recepti.docx", null, null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Content", "CreatedAt", "ItemId", "UserId" },
                values: new object[,]
                {
                    { 5, "Komentar 5", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2883), 19, 3 },
                    { 6, "Komentar 6", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2885), 20, 2 },
                    { 20, "Komentar 20", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2897), 19, 2 },
                    { 21, "Komentar 21", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2898), 20, 3 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CreatedAt", "DiskId", "Item_type", "LastChangedAt", "Name", "ParentFolderId", "ParentFolderItemId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(682), 1, "Folder", null, "Moje slike", 4, null },
                    { 3, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(525), 1, "Folder", null, "Web-prog", 2, null },
                    { 6, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(688), 1, "Folder", null, "Projektni-zadaci", 2, null },
                    { 10, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(693), 2, "Folder", null, "Zavrsni-rad", 9, null },
                    { 12, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(695), 3, "Folder", null, "Linux", 11, null },
                    { 13, new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(696), 3, "Folder", null, "Windows", 11, null }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Content", "CreatedAt", "DiskId", "Item_type", "LastChangedAt", "Name", "ParentFolderId", "ParentFolderItemId" },
                values: new object[,]
                {
                    { 16, "Content for Fesb Predavanja Slides", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1620), 1, "File", null, "predavanje.txt", 2, null },
                    { 18, "Content for Personal Documents", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1624), 1, "File", null, "osobni-dokument.docx", 5, null },
                    { 21, "Class notes", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1629), 1, "File", null, "notes.txt", 2, null },
                    { 23, "A random picture", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1631), 1, "File", null, "picture-description.txt", 4, null },
                    { 24, "List of tasks", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1633), 1, "File", null, "tasklist.docx", 9, null },
                    { 26, "Notes on OS", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1650), 3, "File", null, "system-notes.txt", 11, null },
                    { 29, "Plan for studying", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1680), 3, "File", null, "study-plan.txt", 14, null }
                });

            migrationBuilder.InsertData(
                table: "SharedItems",
                columns: new[] { "SharedItemId", "ItemId", "ItemName", "UserId" },
                values: new object[,]
                {
                    { 5, 19, "Review.txt", 2 },
                    { 6, 20, "Recepti.docx", 3 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Content", "CreatedAt", "ItemId", "UserId" },
                values: new object[,]
                {
                    { 2, "Komentar 2", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2879), 16, 1 },
                    { 4, "Komentar 4", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2882), 18, 2 },
                    { 7, "Komentar 7", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2886), 21, 1 },
                    { 9, "Komentar 9", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2887), 23, 2 },
                    { 10, "Komentar 10", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2889), 24, 1 },
                    { 12, "Komentar 12", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2890), 26, 2 },
                    { 15, "Komentar 15", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2893), 29, 3 },
                    { 17, "Komentar 17", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2894), 16, 2 },
                    { 19, "Komentar 19", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2896), 18, 1 },
                    { 22, "Komentar 22", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2898), 21, 1 },
                    { 24, "Komentar 24", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2900), 23, 3 },
                    { 25, "Komentar 25", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2901), 24, 1 },
                    { 27, "Komentar 27", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2902), 26, 3 },
                    { 30, "Komentar 30", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2904), 29, 3 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Content", "CreatedAt", "DiskId", "Item_type", "LastChangedAt", "Name", "ParentFolderId", "ParentFolderItemId" },
                values: new object[,]
                {
                    { 15, "Content for Dump Domaci Notes", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1435), 1, "File", null, "domaci.docx", 1, null },
                    { 17, "Content for Web Programiranje Code", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1623), 1, "File", null, "preza.pdf", 3, null },
                    { 22, "Project summary", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1630), 1, "File", null, "summary.pdf", 6, null },
                    { 25, "Thesis draft", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1649), 2, "File", null, "thesis.docx", 10, null },
                    { 27, "Linux guide", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1651), 3, "File", null, "linux-guide.pdf", 12, null },
                    { 28, "Windows FAQ", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(1680), 3, "File", null, "windows-faq.docx", 13, null }
                });

            migrationBuilder.InsertData(
                table: "SharedItems",
                columns: new[] { "SharedItemId", "ItemId", "ItemName", "UserId" },
                values: new object[,]
                {
                    { 2, 16, "predavanje.txt", 2 },
                    { 4, 18, "osobni-dokument.docx", 1 },
                    { 7, 21, "notes.txt", 1 },
                    { 9, 23, "picture.jpg", 3 },
                    { 10, 24, "tasklist.docx", 1 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Content", "CreatedAt", "ItemId", "UserId" },
                values: new object[,]
                {
                    { 1, "Komentar 1", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2345), 15, 1 },
                    { 3, "Komentar 3", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2881), 17, 1 },
                    { 8, "Komentar 8", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2887), 22, 3 },
                    { 11, "Komentar 11", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2890), 25, 3 },
                    { 13, "Komentar 13", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2891), 27, 1 },
                    { 14, "Komentar 14", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2892), 28, 2 },
                    { 16, "Komentar 16", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2893), 15, 1 },
                    { 18, "Komentar 18", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2895), 17, 3 },
                    { 23, "Komentar 23", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2899), 22, 2 },
                    { 26, "Komentar 26", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2901), 25, 2 },
                    { 28, "Komentar 28", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2903), 27, 1 },
                    { 29, "Komentar 29", new DateTime(2024, 12, 28, 14, 49, 26, 608, DateTimeKind.Utc).AddTicks(2904), 28, 2 }
                });

            migrationBuilder.InsertData(
                table: "SharedItems",
                columns: new[] { "SharedItemId", "ItemId", "ItemName", "UserId" },
                values: new object[,]
                {
                    { 1, 15, "domaci.docx", 1 },
                    { 3, 17, "preza.pdf", 3 },
                    { 8, 22, "summary.pdf", 2 }
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
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SharedItems",
                keyColumn: "SharedItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SharedItems",
                keyColumn: "SharedItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SharedItems",
                keyColumn: "SharedItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SharedItems",
                keyColumn: "SharedItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SharedItems",
                keyColumn: "SharedItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SharedItems",
                keyColumn: "SharedItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SharedItems",
                keyColumn: "SharedItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SharedItems",
                keyColumn: "SharedItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SharedItems",
                keyColumn: "SharedItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SharedItems",
                keyColumn: "SharedItemId",
                keyValue: 10);

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
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 29);

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
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6);

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
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9);

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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Disks",
                keyColumn: "DiskId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);
        }
    }
}
