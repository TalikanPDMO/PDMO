using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingMapRegions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "MapRegionIds",
                table: "Maps",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MapRegions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TimeCreated = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    EditorName = table.Column<string>(nullable: true),
                    EditorColor = table.Column<byte[]>(nullable: true),
                    Folder = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    EnterEvent = table.Column<Guid>(nullable: false),
                    MoveEvent = table.Column<Guid>(nullable: false),
                    ExitEvent = table.Column<Guid>(nullable: false),
                    MapRegionCommands = table.Column<string>(nullable: true),
                    EnterRequirements = table.Column<string>(nullable: true),
                    ExitRequirements = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapRegions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MapRegions");

            migrationBuilder.DropColumn(
                name: "MapRegionIds",
                table: "Maps");
        }
    }
}
