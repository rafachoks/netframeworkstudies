using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blinks.Project.Data.Migrations
{
    public partial class secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "TB_USER",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "TB_USER");
        }
    }
}
