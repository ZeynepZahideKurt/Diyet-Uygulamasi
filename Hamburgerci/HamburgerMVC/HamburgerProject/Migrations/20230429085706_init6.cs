using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerProject.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "87f97d4d-ff25-413b-836a-e878134c3e4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a3e1ec79-8160-4038-8aa5-b9c58cf36a52");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6b34e167-409b-4ad5-8243-d7ad9033dfc8", "AQAAAAEAACcQAAAAEAaYCxqrerWiMqxTmIPu3Mii1tS4/3PDF2x+3cas67iupsn1K9X0GN0ABLIzeHF3kA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
