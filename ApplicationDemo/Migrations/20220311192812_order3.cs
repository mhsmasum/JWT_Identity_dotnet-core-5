using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApplicationDemo.Migrations
{
    public partial class order3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order3Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order3Id = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order3Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order3Details_Order3_Order3Id",
                        column: x => x.Order3Id,
                        principalTable: "Order3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order3Details_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order3Details_Order3Id",
                table: "Order3Details",
                column: "Order3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order3Details_ProductId",
                table: "Order3Details",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order3Details");

            migrationBuilder.DropTable(
                name: "Order3");
        }
    }
}
