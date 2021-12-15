using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    PhoneNUmber = table.Column<string>(maxLength: 50, nullable: true),
                    Password = table.Column<string>(maxLength: 20, nullable: true),
                    CfId = table.Column<string>(maxLength: 20, nullable: true),
                    LightOjId = table.Column<string>(maxLength: 20, nullable: true),
                    CodechefId = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_users");
        }
    }
}
