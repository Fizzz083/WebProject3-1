using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Migrations.TeamDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_teams",
                columns: table => new
                {
                    TId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(maxLength: 20, nullable: false),
                    Member1 = table.Column<string>(maxLength: 50, nullable: false),
                    Member2 = table.Column<string>(maxLength: 50, nullable: false),
                    Member3 = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    phonenumber = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__teams", x => x.TId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_teams");
        }
    }
}
