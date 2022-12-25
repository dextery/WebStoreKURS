using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStoreKURS.Migrations
{
    public partial class OrderFive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_orderID",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Part_partID",
                table: "OrderDetail");

            migrationBuilder.RenameColumn(
                name: "partID",
                table: "OrderDetail",
                newName: "partid");

            migrationBuilder.RenameColumn(
                name: "orderID",
                table: "OrderDetail",
                newName: "orderid");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_partID",
                table: "OrderDetail",
                newName: "IX_OrderDetail_partid");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_orderID",
                table: "OrderDetail",
                newName: "IX_OrderDetail_orderid");

            migrationBuilder.AlterColumn<int>(
                name: "partid",
                table: "OrderDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "orderid",
                table: "OrderDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "orderAIDI",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "partAIDI",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_orderid",
                table: "OrderDetail",
                column: "orderid",
                principalTable: "Order",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Part_partid",
                table: "OrderDetail",
                column: "partid",
                principalTable: "Part",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_orderid",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Part_partid",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "orderAIDI",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "partAIDI",
                table: "OrderDetail");

            migrationBuilder.RenameColumn(
                name: "partid",
                table: "OrderDetail",
                newName: "partID");

            migrationBuilder.RenameColumn(
                name: "orderid",
                table: "OrderDetail",
                newName: "orderID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_partid",
                table: "OrderDetail",
                newName: "IX_OrderDetail_partID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_orderid",
                table: "OrderDetail",
                newName: "IX_OrderDetail_orderID");

            migrationBuilder.AlterColumn<int>(
                name: "partID",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "orderID",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_orderID",
                table: "OrderDetail",
                column: "orderID",
                principalTable: "Order",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Part_partID",
                table: "OrderDetail",
                column: "partID",
                principalTable: "Part",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
