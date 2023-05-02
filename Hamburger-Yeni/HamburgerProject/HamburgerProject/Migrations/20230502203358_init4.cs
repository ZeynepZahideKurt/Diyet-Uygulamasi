using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerProject.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "0bf00f87-a665-43a9-a969-4a523531c694", "ADMİN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "739d0e47-a37a-4409-9217-5b4f0e3512ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27b517a2-898e-4f1e-bae1-543cf7ae5bd5", "AQAAAAEAACcQAAAAEKHR4m+dWHnIbBkCSW4UQsy75xaAucLIgw5AP5cYCobBmnd3Ns8L2xNDoGhKgdy1SQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbf8aad3-d0cf-43c8-a865-7c8b3c60e71a", "AQAAAAEAACcQAAAAEBt3WHt/fUzzEUveo2oomZI9Zef1be5n5M7mT+9LsJTdq7LZTwreA0h0Vv669Zu8FA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "ddb76499-d23d-4ac3-9495-1f277d2ead77", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "083a54f6-aaec-4a32-9244-01bb7f04b018");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdf26d80-510d-498f-a98d-42a575f1a839", "AQAAAAEAACcQAAAAEIf0y+W/jH2IHQ1ita+l2xhJXrHdTw/tJx067DBBv2WsRbqDxga3gbRMT9TP8G85vA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4849866-da84-4d26-812b-8e9279d2b4e8", "AQAAAAEAACcQAAAAEMxdkyDeytXsWj0IODA+GLTPcUGb6dIT3AecK6fE4QKz1u2A2cv0J/3vvejxDMM6kA==" });
        }
    }
}
