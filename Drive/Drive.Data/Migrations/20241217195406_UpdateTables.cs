using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drive.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_FolderId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_FolderId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FolderId",
                table: "Items");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangedAt",
                table: "Items",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangedAt",
                table: "Items",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FolderId",
                table: "Items",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_FolderId",
                table: "Items",
                column: "FolderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Items_FolderId",
                table: "Items",
                column: "FolderId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
