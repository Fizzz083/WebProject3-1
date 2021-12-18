using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Migrations.ArchiveDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_archives",
                columns: table => new
                {
                    AId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(maxLength: 20, nullable: false),
                    Member1 = table.Column<string>(maxLength: 50, nullable: false),
                    Member2 = table.Column<string>(maxLength: 50, nullable: false),
                    Member3 = table.Column<string>(maxLength: 50, nullable: false),
                    ContestName = table.Column<string>(maxLength: 1000, nullable: false),
                    Year = table.Column<string>(maxLength: 30, nullable: false),
                    Position = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__archives", x => x.AId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_archives");
        }
    }
}
