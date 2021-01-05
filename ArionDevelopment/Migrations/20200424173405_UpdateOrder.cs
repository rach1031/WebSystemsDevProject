using Microsoft.EntityFrameworkCore.Migrations;

namespace ArionDevelopment.Migrations
{
    public partial class UpdateOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreditCard",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CreditCard",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
