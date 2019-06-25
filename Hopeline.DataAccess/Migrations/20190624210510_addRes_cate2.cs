using Microsoft.EntityFrameworkCore.Migrations;

namespace Hopeline.DataAccess.Migrations
{
    public partial class addRes_cate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "resource_category_id",
                table: "resources");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "resource_category_id",
                table: "resources",
                nullable: false,
                defaultValue: 0);
        }
    }
}
