using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityRegistrar.Migrations
{
    public partial class EnrollDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EnrollDate",
                table: "Students",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnrollDate",
                table: "Students");
        }
    }
}
