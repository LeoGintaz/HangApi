using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HangApi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wordss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Theme = table.Column<string>(type: "TEXT", nullable: false),
                    WordOne = table.Column<string>(type: "TEXT", nullable: false),
                    WordTwo = table.Column<string>(type: "TEXT", nullable: false),
                    WordThree = table.Column<string>(type: "TEXT", nullable: false),
                    WordFour = table.Column<string>(type: "TEXT", nullable: false),
                    WordFive = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wordss", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "wordss",
                columns: new[] { "Id", "Theme", "WordFive", "WordFour", "WordOne", "WordThree", "WordTwo" },
                values: new object[,]
                {
                    { 1, "animals", "zebra", "hipopotomus", "panther", "frog", "giraffe" },
                    { 2, "lithuanian cities", "klaipeda", "panevezys", "kaunas", "siauliai", "vilnius" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wordss");
        }
    }
}
