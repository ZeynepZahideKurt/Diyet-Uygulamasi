using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerProject.Migrations
{
    public partial class init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "44df5b9e-0e69-404f-be60-ae27c9460769");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "bc1112bf-12a4-4924-8591-683e601b3a57");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c479a091-76e5-4e25-9742-41e33e1553c1", "AQAAAAEAACcQAAAAEBk5rFwEm2Kkj8MLlMMHcQoOenfocYeFrtKqsP015nwj/mScPVwU1YPlsTlUNmns6Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
