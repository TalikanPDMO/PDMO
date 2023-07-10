using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingMinMaxLevelToNpcsAndSpawns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LevelScalings",
                table: "Npcs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LevelRange",
                table: "Npcs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LevelScalings",
                table: "Npcs");

            migrationBuilder.DropColumn(
                name: "LevelRange",
                table: "Npcs");
        }
    }
}
