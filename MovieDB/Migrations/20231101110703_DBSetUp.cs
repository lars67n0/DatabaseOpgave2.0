using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDB.Migrations
{
    /// <inheritdoc />
    public partial class DBSetUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NameBasics",
                columns: table => new
                {
                    NConst = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PrimaryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    DeathYear = table.Column<int>(type: "int", nullable: false),
                    PrimaryProfession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KnownForTitles = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NameBasics", x => x.NConst);
                });

            migrationBuilder.CreateTable(
                name: "TitleBasics",
                columns: table => new
                {
                    TConst = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TitleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdult = table.Column<bool>(type: "bit", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    EndYear = table.Column<int>(type: "int", nullable: true),
                    RuntimeMinutes = table.Column<int>(type: "int", nullable: false),
                    Genres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleBasics", x => x.TConst);
                });

            migrationBuilder.CreateTable(
                name: "TitleCrew",
                columns: table => new
                {
                    TConst = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Directors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Writers = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleCrew", x => x.TConst);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NameBasics");

            migrationBuilder.DropTable(
                name: "TitleBasics");

            migrationBuilder.DropTable(
                name: "TitleCrew");
        }
    }
}
