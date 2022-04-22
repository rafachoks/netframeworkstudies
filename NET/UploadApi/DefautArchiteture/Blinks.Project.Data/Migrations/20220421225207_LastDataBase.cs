using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blinks.Project.Data.Migrations
{
    public partial class LastDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "TB_USER",
                newName: "NR_AGE");

            migrationBuilder.AlterColumn<int>(
                name: "NR_AGE",
                table: "TB_USER",
                type: "Int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NR_AGE",
                table: "TB_USER",
                newName: "Age");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "TB_USER",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "Int",
                oldDefaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfile_TB_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "TB_USER",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_UserId",
                table: "UserProfile",
                column: "UserId");
        }
    }
}
