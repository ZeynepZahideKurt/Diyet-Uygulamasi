using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerProject.Migrations
{
    public partial class init10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtraOrder_Extras_ExtrasId",
                table: "ExtraOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtraOrder_Orders_OrdersId",
                table: "ExtraOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuOrder_Menus_MenusId",
                table: "MenuOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuOrder_Orders_OrdersId",
                table: "MenuOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuOrder",
                table: "MenuOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExtraOrder",
                table: "ExtraOrder");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "MenuOrder",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "MenusId",
                table: "MenuOrder",
                newName: "MenuId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuOrder_OrdersId",
                table: "MenuOrder",
                newName: "IX_MenuOrder_OrderId");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "ExtraOrder",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "ExtrasId",
                table: "ExtraOrder",
                newName: "ExtraId");

            migrationBuilder.RenameIndex(
                name: "IX_ExtraOrder_OrdersId",
                table: "ExtraOrder",
                newName: "IX_ExtraOrder_OrderId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MenuOrder",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ExtraOrder",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuOrder",
                table: "MenuOrder",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExtraOrder",
                table: "ExtraOrder",
                column: "Id");

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 2, 0, "cc7321ab-d149-4679-90f8-7d3e1467d30a", "benuser@gmail.com", false, false, null, null, "USER", "AQAAAAEAACcQAAAAEIaE8TD8DzWNY+Tf6ZE3ZnBK7sq6LJkIFZYO1BOt3xhAAkkZE9nSNBcU6uSe1vcDkQ==", null, false, null, false, "User" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_MenuOrder_MenuId",
                table: "MenuOrder",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraOrder_ExtraId",
                table: "ExtraOrder",
                column: "ExtraId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraOrder_Extras_ExtraId",
                table: "ExtraOrder",
                column: "ExtraId",
                principalTable: "Extras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraOrder_Orders_OrderId",
                table: "ExtraOrder",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuOrder_Menus_MenuId",
                table: "MenuOrder",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuOrder_Orders_OrderId",
                table: "MenuOrder",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtraOrder_Extras_ExtraId",
                table: "ExtraOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtraOrder_Orders_OrderId",
                table: "ExtraOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuOrder_Menus_MenuId",
                table: "MenuOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuOrder_Orders_OrderId",
                table: "MenuOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuOrder",
                table: "MenuOrder");

            migrationBuilder.DropIndex(
                name: "IX_MenuOrder_MenuId",
                table: "MenuOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExtraOrder",
                table: "ExtraOrder");

            migrationBuilder.DropIndex(
                name: "IX_ExtraOrder_ExtraId",
                table: "ExtraOrder");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MenuOrder");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ExtraOrder");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "MenuOrder",
                newName: "OrdersId");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "MenuOrder",
                newName: "MenusId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuOrder_OrderId",
                table: "MenuOrder",
                newName: "IX_MenuOrder_OrdersId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "ExtraOrder",
                newName: "OrdersId");

            migrationBuilder.RenameColumn(
                name: "ExtraId",
                table: "ExtraOrder",
                newName: "ExtrasId");

            migrationBuilder.RenameIndex(
                name: "IX_ExtraOrder_OrderId",
                table: "ExtraOrder",
                newName: "IX_ExtraOrder_OrdersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuOrder",
                table: "MenuOrder",
                columns: new[] { "MenusId", "OrdersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExtraOrder",
                table: "ExtraOrder",
                columns: new[] { "ExtrasId", "OrdersId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraOrder_Extras_ExtrasId",
                table: "ExtraOrder",
                column: "ExtrasId",
                principalTable: "Extras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraOrder_Orders_OrdersId",
                table: "ExtraOrder",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuOrder_Menus_MenusId",
                table: "MenuOrder",
                column: "MenusId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuOrder_Orders_OrdersId",
                table: "MenuOrder",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
