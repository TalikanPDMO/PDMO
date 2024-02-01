using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations
{
    public partial class AddingVitalsToPlayerItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VitalBuffs",
                table: "Player_Items",
                defaultValue: "[0,0]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VitalBuffs",
                table: "Player_Bank",
                defaultValue: "[0,0]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VitalBuffs",
                table: "Guild_Bank",
                defaultValue: "[0,0]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VitalBuffs",
                table: "Bag_Items",
                defaultValue: "[0,0]",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VitalBuffs",
                table: "Player_Items");

            migrationBuilder.DropColumn(
                name: "VitalBuffs",
                table: "Player_Bank");

            migrationBuilder.DropColumn(
                name: "VitalBuffs",
                table: "Guild_Bank");

            migrationBuilder.DropColumn(
                name: "VitalBuffs",
                table: "Bag_Items");
        }
    }
}
