using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Migrations.AddProblemsDb
{
    public partial class InitialCreate : Migration
    {
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_addProblems",
                columns: table => new
                {
                    Pid = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PName = table.Column<string>(maxLength: 100, nullable: false),
                    PLink = table.Column<string>(maxLength: 1000, nullable: false),
                    PTag = table.Column<string>(maxLength: 200, nullable: true),
                    PIdea = table.Column<string>(maxLength: 300, nullable: true),
                    PAddedBy = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__addProblems", x => x.Pid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_addProblems");
        }
    }
}
