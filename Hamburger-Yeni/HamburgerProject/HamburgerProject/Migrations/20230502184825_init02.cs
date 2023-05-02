using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerProject.Migrations
{
    public partial class init02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "1d288bd7-0b47-4e8b-b9af-35451e3227fa", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "86cd7ca6-df68-4571-b3f4-740cd4d5741b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc136658-70c7-4173-a463-73aa21f0ea48", "AQAAAAEAACcQAAAAEBda7kRrzymKun20JC4U9XZmrF1aCVPiepEXVkP1/6x6YhKHlwGVCEyFLzFd8UU20g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24b1017d-c9e3-4331-ba6f-80016171d088", "AQAAAAEAACcQAAAAEFcoZy4wb8hJeZ/lLiELjvaCMfmYYbZN5JX3WSy/tU0rANoccV5sz2g+5+2N1MS3tw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "723f96c5-b2b3-4fdc-97be-8c3dea079f8a", "ADMİN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "047d3917-692c-489d-8a3a-71269af1213c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99f6a6e1-49ca-4d19-952d-045f380cdca1", "AQAAAAEAACcQAAAAEMjo8+lOalfPc6B4iKxm4DzMf3SZKKtkiePphxHPoUwRBJFwv0at+rMCPYmGZrlrJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46b278b1-c909-4925-bd6b-d41cf0140365", "AQAAAAEAACcQAAAAEMvn10Z8PNRz0aKyLU51HdHJjQHuuIPxJoGZNvyvGOpjTjKOxPUv6LGtRshNqAcSOQ==" });
        }
    }
}
