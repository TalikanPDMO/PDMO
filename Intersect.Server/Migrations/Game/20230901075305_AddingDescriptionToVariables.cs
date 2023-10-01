using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class AddingDescriptionToVariables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ServerVariables",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PlayerVariables",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ServerVariables");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PlayerVariables");
        }
    }
}
