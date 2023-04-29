using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerProject.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "00dd029f-5873-4eeb-b26f-d982b7d9d927");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "88bccbe3-d983-4883-9a70-bc4ffbcc4f4f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38ba81e4-d731-43f7-a70b-670886b7b1a9", "AQAAAAEAACcQAAAAEMAsAPRLlUHx47l+wCDTuNoG1SIPEE1paw98EhAbCR9JGgZOkI3v9IgjX67hyjIlBg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "36e45867-96c1-4c2b-a6bb-fbfce2be3353");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "76c44ae0-0593-4431-aae5-31b4c716348d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1405cb43-7277-408e-8c62-371b90998255", "AQAAAAEAACcQAAAAEL27IybtlD7tJgxaGCNvN9VWeRKoz5VjrccwqcRrtsY9gkO3t9qKu119H7wOU5JgGw==" });
        }
    }
}
