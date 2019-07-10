using Microsoft.EntityFrameworkCore.Migrations;

namespace Hopeline.DataAccess.Migrations
{
    public partial class addEnable_flg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "enable_flg",
                table: "resource_categories",
                nullable: false,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "enable_flg",
                table: "resource_categories");
        }
    }
}
