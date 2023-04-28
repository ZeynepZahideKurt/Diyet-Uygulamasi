using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerProject.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtraOrder_Orders_OrdersID",
                table: "ExtraOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Orders_OrderId",
                table: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Menus_OrderId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Menus");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "Orders",
                newName: "AppUserId");

            migrationBuilder.RenameColumn(
                name: "OrdersID",
                table: "ExtraOrder",
                newName: "OrdersId");

            migrationBuilder.RenameIndex(
                name: "IX_ExtraOrder_OrdersID",
                table: "ExtraOrder",
                newName: "IX_ExtraOrder_OrdersId");

            migrationBuilder.CreateTable(
                name: "MenuOrder",
                columns: table => new
                {
                    MenusId = table.Column<int>(type: "int", nullable: false),
                    OrdersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuOrder", x => new { x.MenusId, x.OrdersId });
                    table.ForeignKey(
                        name: "FK_MenuOrder_Menus_MenusId",
                        column: x => x.MenusId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuOrder_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuOrder_OrdersId",
                table: "MenuOrder",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraOrder_Orders_OrdersId",
                table: "ExtraOrder",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtraOrder_Orders_OrdersId",
                table: "ExtraOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "MenuOrder");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "Orders",
                newName: "MenuId");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "ExtraOrder",
                newName: "OrdersID");

            migrationBuilder.RenameIndex(
                name: "IX_ExtraOrder_OrdersId",
                table: "ExtraOrder",
                newName: "IX_ExtraOrder_OrdersID");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Menus_OrderId",
                table: "Menus",
                column: "OrderId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraOrder_Orders_OrdersID",
                table: "ExtraOrder",
                column: "OrdersID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Orders_OrderId",
                table: "Menus",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
