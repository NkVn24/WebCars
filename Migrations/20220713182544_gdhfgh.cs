using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCars.Migrations
{
    public partial class gdhfgh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RightRule",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RightRule",
                table: "Cars");
        }
    }
}
