using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingAttackRangeToNpcsAndItemsAndClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "AttackRange",
                table: "Npcs",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "AttackRange",
                table: "Items",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "AttackRange",
                table: "Classes",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttackRange",
                table: "Npcs");

            migrationBuilder.DropColumn(
                name: "AttackRange",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "AttackRange",
                table: "Classes");
        }
    }
}
