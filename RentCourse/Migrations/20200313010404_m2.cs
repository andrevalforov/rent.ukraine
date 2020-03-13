using Microsoft.EntityFrameworkCore.Migrations;

namespace RentCourse.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Products",
                nullable: true);
        }
    }
}
