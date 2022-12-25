using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStoreKURS.Migrations
{
    public partial class Ordersthree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Part_partId",
                table: "OrderDetail");

            migrationBuilder.RenameColumn(
                name: "partId",
                table: "OrderDetail",
                newName: "partID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_partId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_partID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Part_partID",
                table: "OrderDetail",
                column: "partID",
                principalTable: "Part",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Part_partID",
                table: "OrderDetail");

            migrationBuilder.RenameColumn(
                name: "partID",
                table: "OrderDetail",
                newName: "partId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_partID",
                table: "OrderDetail",
                newName: "IX_OrderDetail_partId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Part_partId",
                table: "OrderDetail",
                column: "partId",
                principalTable: "Part",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
