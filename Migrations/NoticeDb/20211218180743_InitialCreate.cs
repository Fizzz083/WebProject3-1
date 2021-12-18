using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Migrations.NoticeDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_notices",
                columns: table => new
                {
                    NId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShortDescription = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 1550, nullable: false),
                    Time = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__notices", x => x.NId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_notices");
        }
    }
}
