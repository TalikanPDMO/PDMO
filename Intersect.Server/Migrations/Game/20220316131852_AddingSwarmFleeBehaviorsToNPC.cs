using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingSwarmFleeBehaviorsToNPC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AttackOnFlee",
                table: "Npcs",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "SwarmList",
                table: "Npcs",
                defaultValue: "[]",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SwarmAll",
                table: "Npcs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SwarmOnPlayer",
                table: "Npcs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SwarmRange",
                table: "Npcs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttackOnFlee",
                table: "Npcs");

            migrationBuilder.DropColumn(
                name: "SwarmList",
                table: "Npcs");

            migrationBuilder.DropColumn(
                name: "SwarmAll",
                table: "Npcs");

            migrationBuilder.DropColumn(
                name: "SwarmOnPlayer",
                table: "Npcs");

            migrationBuilder.DropColumn(
                name: "SwarmRange",
                table: "Npcs");
        }
    }
}
