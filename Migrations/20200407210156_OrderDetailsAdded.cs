using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class OrderDetailsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Pies_PieId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "PieId",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Pies_PieId",
                table: "OrderDetails",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Pies_PieId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "PieId",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Pies_PieId",
                table: "OrderDetails",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
