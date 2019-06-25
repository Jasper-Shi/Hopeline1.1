using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hopeline.DataAccess.Migrations
{
    public partial class addRes_cate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resources_resource_categories_resource_categoryId",
                table: "resources");

            migrationBuilder.DropIndex(
                name: "IX_resources_resource_categoryId",
                table: "resources");

            migrationBuilder.DropColumn(
                name: "resource_categoryId",
                table: "resources");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "resources",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "Foreign_key_resource_category",
                table: "resources",
                column: "Id",
                principalTable: "resource_categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Foreign_key_resource_category",
                table: "resources");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "resources",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "resource_categoryId",
                table: "resources",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_resources_resource_categoryId",
                table: "resources",
                column: "resource_categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_resources_resource_categories_resource_categoryId",
                table: "resources",
                column: "resource_categoryId",
                principalTable: "resource_categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
