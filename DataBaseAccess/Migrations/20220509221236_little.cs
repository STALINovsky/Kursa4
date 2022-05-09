using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBaseAccess.Migrations
{
    public partial class little : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseProducts_Consumers_ConsumerId",
                table: "PurchaseProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseProducts_Orders_OrderId",
                table: "PurchaseProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseProducts",
                table: "PurchaseProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "PurchaseProducts",
                newName: "OrderedBooks");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseProducts_OrderId",
                table: "OrderedBooks",
                newName: "IX_OrderedBooks_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseProducts_ConsumerId",
                table: "OrderedBooks",
                newName: "IX_OrderedBooks_ConsumerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderedBooks",
                table: "OrderedBooks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedBooks_Consumers_ConsumerId",
                table: "OrderedBooks",
                column: "ConsumerId",
                principalTable: "Consumers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedBooks_Orders_OrderId",
                table: "OrderedBooks",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderedBooks_Consumers_ConsumerId",
                table: "OrderedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderedBooks_Orders_OrderId",
                table: "OrderedBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderedBooks",
                table: "OrderedBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "OrderedBooks",
                newName: "PurchaseProducts");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_OrderedBooks_OrderId",
                table: "PurchaseProducts",
                newName: "IX_PurchaseProducts_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderedBooks_ConsumerId",
                table: "PurchaseProducts",
                newName: "IX_PurchaseProducts_ConsumerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseProducts",
                table: "PurchaseProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseProducts_Consumers_ConsumerId",
                table: "PurchaseProducts",
                column: "ConsumerId",
                principalTable: "Consumers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseProducts_Orders_OrderId",
                table: "PurchaseProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
