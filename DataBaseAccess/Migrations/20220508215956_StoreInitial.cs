using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBaseAccess.Migrations
{
    public partial class StoreInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Producers_ProducerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Producers_ProducerId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProducerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProducerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProducerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProducerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "ConsumerId",
                table: "PurchaseProducts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConsumerId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsumerId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Consumers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseProducts_ConsumerId",
                table: "PurchaseProducts",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ConsumerId",
                table: "Products",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ConsumerId",
                table: "Orders",
                column: "ConsumerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Consumers_ConsumerId",
                table: "Orders",
                column: "ConsumerId",
                principalTable: "Consumers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Consumers_ConsumerId",
                table: "Products",
                column: "ConsumerId",
                principalTable: "Consumers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseProducts_Consumers_ConsumerId",
                table: "PurchaseProducts",
                column: "ConsumerId",
                principalTable: "Consumers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Consumers_ConsumerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Consumers_ConsumerId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseProducts_Consumers_ConsumerId",
                table: "PurchaseProducts");

            migrationBuilder.DropTable(
                name: "Consumers");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseProducts_ConsumerId",
                table: "PurchaseProducts");

            migrationBuilder.DropIndex(
                name: "IX_Products_ConsumerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ConsumerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ConsumerId",
                table: "PurchaseProducts");

            migrationBuilder.DropColumn(
                name: "ConsumerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ConsumerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "ProducerId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProducerId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProducerId",
                table: "Products",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProducerId",
                table: "Orders",
                column: "ProducerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Producers_ProducerId",
                table: "Orders",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Producers_ProducerId",
                table: "Products",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
