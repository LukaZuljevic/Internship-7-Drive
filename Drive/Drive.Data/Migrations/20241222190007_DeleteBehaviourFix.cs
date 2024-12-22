using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drive.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeleteBehaviourFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_ParentFolderId",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "ParentFolderItemId",
                table: "Items",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3074), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3509), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3512), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3666), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3668), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3673), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3674), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3675), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3676), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3678), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3679), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3680), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3681), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3682), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(4497), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(4682), null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ParentFolderItemId" },
                values: new object[] { new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(4684), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 982, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 982, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 982, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 982, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 982, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 982, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 982, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.CreateIndex(
                name: "IX_Items_ParentFolderItemId",
                table: "Items",
                column: "ParentFolderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Items_ParentFolderId",
                table: "Items",
                column: "ParentFolderId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Items_ParentFolderItemId",
                table: "Items",
                column: "ParentFolderItemId",
                principalTable: "Items",
                principalColumn: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_ParentFolderId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_ParentFolderItemId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ParentFolderItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ParentFolderItemId",
                table: "Items");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 587, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 587, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 587, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 18, 54, 18, 586, DateTimeKind.Utc).AddTicks(1736));

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Items_ParentFolderId",
                table: "Items",
                column: "ParentFolderId",
                principalTable: "Items",
                principalColumn: "ItemId");
        }
    }
}
