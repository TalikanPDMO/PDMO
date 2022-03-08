using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingCanPlayerSpellAndProjectilesToNpcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlayerCanProjectileConditions",
                table: "Npcs",
                defaultValue: "[]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlayerCanSpellConditions",
                table: "Npcs",
                defaultValue: "[]",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerCanProjectileConditions",
                table: "Npcs");

            migrationBuilder.DropColumn(
                name: "PlayerCanSpellConditions",
                table: "Npcs");
        }
    }
}
