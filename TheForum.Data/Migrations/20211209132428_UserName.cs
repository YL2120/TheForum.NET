using Microsoft.EntityFrameworkCore.Migrations;

namespace TheForum.Data.Migrations
{
    public partial class UserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author_ID",
                table: "Topics");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Topics",
                type: "nvarchar(25)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Topics");

            migrationBuilder.AddColumn<int>(
                name: "Author_ID",
                table: "Topics",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
