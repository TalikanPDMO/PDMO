using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingCritEffectSpellToItemsAndSpells : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CritEffectSpell",
                table: "Spells",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "Combat_CritEffectSpellReplace",
                table: "Spells",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "CritEffectSpell",
                table: "Items",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "CritEffectSpellReplace",
                table: "Items",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CritEffectSpell",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "Combat_CritEffectSpellReplace",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "CritEffectSpell",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CritEffectSpellReplace",
                table: "Items");
        }
    }
}
