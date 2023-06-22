using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Munafasa.Migrations
{
    /// <inheritdoc />
    public partial class userNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "Technicians");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "Technicians",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "Owners",
                newName: "UserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Technicians",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Owners",
                newName: "NameEn");

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "Technicians",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "Owners",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "Clients",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
