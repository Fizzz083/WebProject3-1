using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Migrations.TeacherInfoDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    FullName = table.Column<string>(maxLength: 150, nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    PhoneNUmber = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__teachers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_teachers");
        }
    }
}
