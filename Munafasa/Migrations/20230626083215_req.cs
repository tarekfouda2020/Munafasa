using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Munafasa.Migrations
{
    /// <inheritdoc />
    public partial class req : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VisitDate",
                table: "Requests",
                newName: "VisitDateTo");

            migrationBuilder.AddColumn<bool>(
                name: "IsUrget",
                table: "Requests",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "VisitDateFrom",
                table: "Requests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsUrget",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "VisitDateFrom",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "VisitDateTo",
                table: "Requests",
                newName: "VisitDate");
        }
    }
}
