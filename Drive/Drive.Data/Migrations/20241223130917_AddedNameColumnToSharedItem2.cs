using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drive.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedNameColumnToSharedItem2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "SharedItems",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 723, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 722, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 722, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 722, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 722, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 722, DateTimeKind.Utc).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 722, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 23, 13, 9, 16, 722, DateTimeKind.Utc).AddTicks(9774));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "SharedItems");

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
    }
}
