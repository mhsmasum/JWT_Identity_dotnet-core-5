using Microsoft.EntityFrameworkCore.Migrations;

namespace ApplicationDemo.Migrations
{
    public partial class order2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order2s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Order2Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem2_Order2s_Order2Id",
                        column: x => x.Order2Id,
                        principalTable: "Order2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem2_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem2_Order2Id",
                table: "OrderItem2",
                column: "Order2Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem2_ProductId",
                table: "OrderItem2",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem2");

            migrationBuilder.DropTable(
                name: "Order2s");
        }
    }
}
