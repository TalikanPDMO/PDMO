using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations
{
    public partial class AddingItemPropertiesToPlayers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemProperties",
                table: "Player_Items",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ItemPropertiesId",
                table: "Player_Hotbar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemProperties",
                table: "Player_Bank",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemProperties",
                table: "Guild_Bank",
                defaultValue: "",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemProperties",
                table: "Bag_Items",
                defaultValue: "",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemProperties",
                table: "Player_Items");

            migrationBuilder.DropColumn(
                name: "ItemPropertiesId",
                table: "Player_Hotbar");

            migrationBuilder.DropColumn(
                name: "ItemProperties",
                table: "Player_Bank");

            migrationBuilder.DropColumn(
                name: "ItemProperties",
                table: "Guild_Bank");

            migrationBuilder.DropColumn(
                name: "ItemProperties",
                table: "Bag_Items");
        }
    }
}
