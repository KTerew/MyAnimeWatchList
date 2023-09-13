using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAnimeWatchList.Data.Migrations
{
    /// <inheritdoc />
    public partial class Removed_UserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Episodes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
