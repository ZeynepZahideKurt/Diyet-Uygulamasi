using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerProject.Migrations
{
    public partial class init11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "17755741-5b24-4fcf-b148-b9f8e33f1a5e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "42227599-13a4-45c9-add3-259288a4a2c0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d08f86b-9551-47b9-acd4-c9ed7c0727ab", "AQAAAAEAACcQAAAAEAKQPoSD85K1m/gqdPFg76N7jdn3GVZYbmtIVRKqNBQsx7vnpblRYiF/3mOMbJkYVA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62fed9f2-dac5-42fe-b9fa-6830379a2e52", "AQAAAAEAACcQAAAAEBomZ1fS3/wD1f5m3gTiDIPj8rihlqC+RZ5Jg8Kvdvkl+HlYftoEdUs+7ecmeIFVAA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "44beafb1-91c8-47b9-a6b0-9e9ffaeeda78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f3853648-9f45-422c-8bc2-546d98d68911");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c05ac95-d6a7-4378-ac5e-0a9c863f4f31", "AQAAAAEAACcQAAAAEMkY9WXfOsYROoFmXjcJxAOPVfL6ZWRt3DIK9pKViM49YVmdG7E9M8Q0IuDDyzWgRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc7321ab-d149-4679-90f8-7d3e1467d30a", "AQAAAAEAACcQAAAAEIaE8TD8DzWNY+Tf6ZE3ZnBK7sq6LJkIFZYO1BOt3xhAAkkZE9nSNBcU6uSe1vcDkQ==" });
        }
    }
}
