using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBaseAccess.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "PurchasedComponents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedComponents_OrderId",
                table: "PurchasedComponents",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedComponents_Orders_OrderId",
                table: "PurchasedComponents",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedComponents_Orders_OrderId",
                table: "PurchasedComponents");

            migrationBuilder.DropIndex(
                name: "IX_PurchasedComponents_OrderId",
                table: "PurchasedComponents");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "PurchasedComponents");
        }
    }
}
