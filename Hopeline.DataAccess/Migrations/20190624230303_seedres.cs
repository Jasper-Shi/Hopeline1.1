using Microsoft.EntityFrameworkCore.Migrations;

namespace Hopeline.DataAccess.Migrations
{
    public partial class seedres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "communities",
                columns: new[] { "Id", "dateAdded", "desc", "enabled_flg", "image", "title", "url", "user_code" },
                values: new object[,]
                {
                    { 1, "06-24-2019 19:03:03", "Descrption for community 1", 1, null, "Community 1", "www.google.ca", "comm001" },
                    { 2, "06-24-2019 19:03:03", "Descrption for community 2", 0, null, "Community 2", "www.google.ca", "comm002" }
                });

            migrationBuilder.InsertData(
                table: "resource_categories",
                columns: new[] { "Id", "category_decription", "category_name", "dateAdded", "user_code" },
                values: new object[,]
                {
                    { 1, "depression description", "depression", "06-24-2019 19:03:03", "depre001" },
                    { 2, "bullying description", "bullying", "06-24-2019 19:03:03", "bully001" },
                    { 3, "school-related description", "school-related", "06-24-2019 19:03:03", "school001" }
                });

            migrationBuilder.InsertData(
                table: "topics",
                columns: new[] { "Id", "dateAdded", "desc", "enabled_flg", "topic_name", "user_code" },
                values: new object[,]
                {
                    { 1, "06-24-2019 19:03:03", "Despression is a mental disease", 1, "Depression", "Drep001" },
                    { 2, "06-24-2019 19:03:03", "Bullying is bad", 1, "Bullying", "Bullying001" }
                });

            migrationBuilder.InsertData(
                table: "resources",
                columns: new[] { "Id", "dateAdded", "desc", "enabled_flg", "image", "resource_categoryId", "title", "url", "user_code" },
                values: new object[] { 1, "06-24-2019 19:03:03", "Descrpition for the resource", 1, null, 1, "Some resources", "www.google.ca", "res001" });

            migrationBuilder.InsertData(
                table: "resources",
                columns: new[] { "Id", "dateAdded", "desc", "enabled_flg", "image", "resource_categoryId", "title", "url", "user_code" },
                values: new object[] { 2, "06-24-2019 19:03:03", "Description for the res2", 0, null, 2, "Some title for res2", "www.google.ca", "res002" });

            migrationBuilder.InsertData(
                table: "resources",
                columns: new[] { "Id", "dateAdded", "desc", "enabled_flg", "image", "resource_categoryId", "title", "url", "user_code" },
                values: new object[] { 3, "06-24-2019 19:03:03", "Description for the res3", 0, null, 3, "Some title for res3", "www.google.ca", "res003" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "communities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "communities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "resources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "resources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "resources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "topics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "topics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "resource_categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "resource_categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "resource_categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
