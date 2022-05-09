using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBaseAccess.Migrations
{
    public partial class RemoveUserProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Consumers_ConsumerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ConsumerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ConsumerId",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConsumerId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ConsumerId",
                table: "Products",
                column: "ConsumerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Consumers_ConsumerId",
                table: "Products",
                column: "ConsumerId",
                principalTable: "Consumers",
                principalColumn: "Id");
        }
    }
}
