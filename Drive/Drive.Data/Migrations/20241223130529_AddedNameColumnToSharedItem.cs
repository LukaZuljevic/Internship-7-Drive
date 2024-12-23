using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drive.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedNameColumnToSharedItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 323, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 5, 29, 322, DateTimeKind.Utc).AddTicks(3425));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 22, 19, 0, 6, 983, DateTimeKind.Utc).AddTicks(4684));

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
        }
    }
}
