using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingDamageStyleToSpells : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VitalCostStyle",
                table: "Spells",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VitalDiffStyle",
                table: "Spells",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VitalCostStyle",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "VitalDiffStyle",
                table: "Spells");
        }
    }
}
