using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAnimeWatchList.Data.Migrations
{
    /// <inheritdoc />
    public partial class Changed_EpisodeLength_To_NumOfEpisodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EpisodeLength",
                table: "Animes",
                newName: "NumOfEpisodes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumOfEpisodes",
                table: "Animes",
                newName: "EpisodeLength");
        }
    }
}
