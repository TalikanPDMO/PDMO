using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingEditorNameToSpellsAndNpcsAndItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EditorName",
                table: "Spells",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditorName",
                table: "Npcs",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditorName",
                table: "Items",
                defaultValue: "",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EditorName",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "EditorName",
                table: "Npcs");

            migrationBuilder.DropColumn(
                name: "EditorName",
                table: "Items");
        }
    }
}
