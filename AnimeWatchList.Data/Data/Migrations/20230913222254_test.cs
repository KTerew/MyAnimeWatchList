using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAnimeWatchList.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Episodes_AnimeId",
                table: "Episodes",
                column: "AnimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Animes_AnimeId",
                table: "Episodes",
                column: "AnimeId",
                principalTable: "Animes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Animes_AnimeId",
                table: "Episodes");

            migrationBuilder.DropIndex(
                name: "IX_Episodes_AnimeId",
                table: "Episodes");
        }
    }
}
