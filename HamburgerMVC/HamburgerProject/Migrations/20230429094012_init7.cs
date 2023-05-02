using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerProject.Migrations
{
    public partial class init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e3d1a65d-108d-48b1-8622-3983c80a60b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "abfdaafd-8371-423f-9812-dea7ba9c5d69");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac8b3415-aa00-4963-9eb4-681292a1d778", "AQAAAAEAACcQAAAAEArzElGBaPH6zNtCd0HJw4hGnHAZapspoOFFbWdP0OthcmsmfjePRBXbSXJUfkOWIQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
