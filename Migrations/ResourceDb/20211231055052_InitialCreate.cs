using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Migrations.ResourceDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_Resource",
                columns: table => new
                {
                    RId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShortDescription = table.Column<string>(maxLength: 1000, nullable: true),
                    Description = table.Column<string>(maxLength: 10000, nullable: true),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    Topic = table.Column<string>(maxLength: 1000, nullable: true),
                    Datafiles = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Resource", x => x.RId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_Resource");
        }
    }
}
