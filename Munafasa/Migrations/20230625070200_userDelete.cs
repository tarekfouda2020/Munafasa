using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Munafasa.Migrations
{
    /// <inheritdoc />
    public partial class userDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Contacts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Clients",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "AspNetUsers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "AspNetUsers");
        }
    }
}
