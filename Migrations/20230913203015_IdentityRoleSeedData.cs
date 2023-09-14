using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class IdentityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26d4f244-1838-4d1b-8d8d-00010c7ecbe5", "5d8fbb48-9316-414a-83bf-7c4c04f3a3f7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c03637d-6893-4963-b6a1-aa58c204ebda", "12de25a1-2ad2-4132-b866-8828a0a98d16", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6878068-887c-4720-bd39-188d1e9210bf", "3a0c91a8-0e49-4567-a615-bc1cf7867b0f", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26d4f244-1838-4d1b-8d8d-00010c7ecbe5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c03637d-6893-4963-b6a1-aa58c204ebda");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6878068-887c-4720-bd39-188d1e9210bf");
        }
    }
}
