using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Munafasa.Migrations
{
    /// <inheritdoc />
    public partial class userName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "Clients",
                newName: "UserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Clients",
                newName: "NameEn");
        }
    }
}
