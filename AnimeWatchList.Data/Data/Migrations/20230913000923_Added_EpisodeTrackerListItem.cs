using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAnimeWatchList.Data.Migrations
{
    /// <inheritdoc />
    public partial class Added_EpisodeTrackerListItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnimeName",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnimeName",
                table: "Episodes");
        }
    }
}
