using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hopeline.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "communities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateAdded = table.Column<string>(nullable: true),
                    user_code = table.Column<string>(maxLength: 20, nullable: false),
                    image = table.Column<byte[]>(nullable: true),
                    enabled_flg = table.Column<int>(nullable: false),
                    url = table.Column<string>(nullable: false),
                    title = table.Column<string>(maxLength: 50, nullable: false),
                    desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_communities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "resource_categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateAdded = table.Column<string>(nullable: true),
                    user_code = table.Column<string>(nullable: false),
                    category_name = table.Column<string>(nullable: false),
                    category_decription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resource_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "topics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateAdded = table.Column<string>(nullable: true),
                    user_code = table.Column<string>(maxLength: 20, nullable: false),
                    enabled_flg = table.Column<int>(nullable: false),
                    topic_name = table.Column<string>(maxLength: 50, nullable: false),
                    desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "resources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateAdded = table.Column<string>(nullable: true),
                    user_code = table.Column<string>(maxLength: 20, nullable: false),
                    image = table.Column<byte[]>(nullable: true),
                    enabled_flg = table.Column<int>(nullable: false),
                    url = table.Column<string>(nullable: false),
                    title = table.Column<string>(maxLength: 50, nullable: false),
                    desc = table.Column<string>(nullable: true),
                    resource_categoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resources", x => x.Id);
                    table.ForeignKey(
                        name: "Foreign_key_resource_category",
                        column: x => x.resource_categoryId,
                        principalTable: "resource_categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_resources_resource_categoryId",
                table: "resources",
                column: "resource_categoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "communities");

            migrationBuilder.DropTable(
                name: "resources");

            migrationBuilder.DropTable(
                name: "topics");

            migrationBuilder.DropTable(
                name: "resource_categories");
        }
    }
}
