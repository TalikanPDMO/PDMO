using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingCommentToMainGameObjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Spells",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Shops",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Resources",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Quests",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Projectiles",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Npcs",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Items",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Events",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Crafts",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "CraftingTables",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Classes",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Animations",
                defaultValue: "",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Quests");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Projectiles");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Npcs");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Crafts");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "CraftingTables");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Animations");
        }
    }
}
