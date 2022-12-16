using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCSQLServer.Migrations
{
    /// <inheritdoc />
    public partial class GamesListCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "games",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_games", x => x.id);
                    table.ForeignKey(
                        name: "FK_games_category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "MMORPG" },
                    { 2, "First Person Shooter" },
                    { 3, "Simulation" },
                    { 4, "Moba" }
                });

            migrationBuilder.InsertData(
                table: "games",
                columns: new[] { "id", "CategoryId", "name" },
                values: new object[,]
                {
                    { 1, 1, "World of Warcraft" },
                    { 2, 1, "Final Fantasy XIV" },
                    { 3, 2, "CS:GO" },
                    { 4, 2, "Overwatch" },
                    { 5, 3, "The Sims 4" },
                    { 6, 3, "Stardew Valley" },
                    { 7, 4, "League of Legends" },
                    { 8, 4, "Dota 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_games_CategoryId",
                table: "games",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "games");

            migrationBuilder.DropTable(
                name: "category");
        }
    }
}
