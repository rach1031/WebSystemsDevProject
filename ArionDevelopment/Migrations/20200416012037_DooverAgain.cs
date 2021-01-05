using Microsoft.EntityFrameworkCore.Migrations;

namespace ArionDevelopment.Migrations
{
    public partial class DooverAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyTypeID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ColorID",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "BodyType",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "BodyTypeID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColorID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
