using Microsoft.EntityFrameworkCore.Migrations;

namespace ArionDevelopment.Migrations
{
    public partial class DoOver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DailyRate",
                table: "Products",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyRate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Products");
        }
    }
}
