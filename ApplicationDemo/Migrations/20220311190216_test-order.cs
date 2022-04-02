using Microsoft.EntityFrameworkCore.Migrations;

namespace ApplicationDemo.Migrations
{
    public partial class testorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OderItems_Products_ProductId",
                table: "OderItems");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OderItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OderItems_Products_ProductId",
                table: "OderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OderItems_Products_ProductId",
                table: "OderItems");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OderItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OderItems_Products_ProductId",
                table: "OderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
