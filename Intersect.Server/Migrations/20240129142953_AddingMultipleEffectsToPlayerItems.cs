using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations
{
    public partial class AddingMultipleEffectsToPlayerItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Effects",
                table: "Player_Items",
                defaultValue: "[]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Effects",
                table: "Player_Bank",
                defaultValue: "[]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Effects",
                table: "Guild_Bank",
                defaultValue: "[]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Effects",
                table: "Bag_Items",
                defaultValue: "[]",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Effects",
                table: "Player_Items");

            migrationBuilder.DropColumn(
                name: "Effects",
                table: "Player_Bank");

            migrationBuilder.DropColumn(
                name: "Effects",
                table: "Guild_Bank");

            migrationBuilder.DropColumn(
                name: "Effects",
                table: "Bag_Items");
        }
    }
}
