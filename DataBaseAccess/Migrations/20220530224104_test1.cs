using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBaseAccess.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedComponents_Orders_OrderId",
                table: "PurchasedComponents");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "PurchasedComponents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedComponents_Orders_OrderId",
                table: "PurchasedComponents",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedComponents_Orders_OrderId",
                table: "PurchasedComponents");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "PurchasedComponents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedComponents_Orders_OrderId",
                table: "PurchasedComponents",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
