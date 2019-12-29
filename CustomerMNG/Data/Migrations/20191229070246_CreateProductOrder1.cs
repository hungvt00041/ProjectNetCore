using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMNG.Data.Migrations
{
    public partial class CreateProductOrder1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_Order_ProductId",
                table: "ProductOrder");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1da22cd4-ae9f-45ae-b61e-7feec5238f7b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("93526d4e-29f1-49cf-9db7-dff524e62881"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ade03b53-2ffd-4c95-84ce-996b6b375829"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f5f4f9c6-6937-4f5a-bb9d-a3b663232353"));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpDatedDate", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0b5ae8cb-c7fa-4b05-8865-e75235118de2"), null, new DateTime(2019, 12, 29, 7, 2, 45, 584, DateTimeKind.Utc).AddTicks(6894), "Car", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("94f86192-02bc-46a4-94d3-1bb9a28abbe5"), null, new DateTime(2019, 12, 29, 7, 2, 45, 588, DateTimeKind.Utc).AddTicks(4725), "Shoes", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a6a382ad-b561-414c-84f1-98b5fa008073"), null, new DateTime(2019, 12, 29, 7, 2, 45, 588, DateTimeKind.Utc).AddTicks(5149), "Bike", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("8971160f-8509-4218-baa4-bbba38770b9d"), null, new DateTime(2019, 12, 29, 7, 2, 45, 588, DateTimeKind.Utc).AddTicks(5906), "Computer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_Order_OrderId",
                table: "ProductOrder",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_Order_OrderId",
                table: "ProductOrder");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0b5ae8cb-c7fa-4b05-8865-e75235118de2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8971160f-8509-4218-baa4-bbba38770b9d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("94f86192-02bc-46a4-94d3-1bb9a28abbe5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a6a382ad-b561-414c-84f1-98b5fa008073"));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpDatedDate", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("ade03b53-2ffd-4c95-84ce-996b6b375829"), null, new DateTime(2019, 12, 29, 6, 56, 31, 39, DateTimeKind.Utc).AddTicks(6355), "Car", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1da22cd4-ae9f-45ae-b61e-7feec5238f7b"), null, new DateTime(2019, 12, 29, 6, 56, 31, 41, DateTimeKind.Utc).AddTicks(5381), "Shoes", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f5f4f9c6-6937-4f5a-bb9d-a3b663232353"), null, new DateTime(2019, 12, 29, 6, 56, 31, 41, DateTimeKind.Utc).AddTicks(5597), "Bike", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("93526d4e-29f1-49cf-9db7-dff524e62881"), null, new DateTime(2019, 12, 29, 6, 56, 31, 41, DateTimeKind.Utc).AddTicks(5626), "Computer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_Order_ProductId",
                table: "ProductOrder",
                column: "ProductId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
