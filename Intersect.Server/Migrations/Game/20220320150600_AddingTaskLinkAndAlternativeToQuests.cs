using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingTaskLinkAndAlternativeToQuests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TaskAlternatives",
                table: "Quests",
                defaultValue: "[]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaskLinks",
                table: "Quests",
                defaultValue: "[]",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskAlternatives",
                table: "Quests");

            migrationBuilder.DropColumn(
                name: "TaskLinks",
                table: "Quests");
        }
    }
}
