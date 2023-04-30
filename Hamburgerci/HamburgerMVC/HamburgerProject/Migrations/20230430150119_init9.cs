using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerProject.Migrations
{
    public partial class init9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Piece",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Extras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "60160514-30ab-4c16-bda8-8e4bd6f55621");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "dbfb8e1b-23fb-4643-b0b1-adf120c45d59");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7c13cef-9b25-4339-838e-132a5607f5e0", "AQAAAAEAACcQAAAAEBojRyIRwqMMK9FkLjVF73mhcFdtY10I/Gk8KApkVfdZ1Q1gPxHtpZRtauqq/sNgWA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Piece",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Extras");

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
    }
}
