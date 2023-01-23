using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingElementalTypesToResourcesClassesNpcsItemsSpells : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ElementalType",
                table: "Spells",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ElementalTypes",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElementalTypes",
                table: "Npcs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ElementalType",
                table: "Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ElementalTypes",
                table: "Classes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElementalType",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "ElementalTypes",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "ElementalTypes",
                table: "Npcs");

            migrationBuilder.DropColumn(
                name: "ElementalType",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ElementalTypes",
                table: "Classes");
        }
    }
}
