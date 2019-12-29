using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMNG.Data.Migrations
{
    public partial class CreateProductOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("83081a01-0ce2-4225-ba77-ef02fa702577"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("83734e7c-dc2f-41ae-88bf-660bcd143cdc"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a492a623-c731-4961-9e6f-cd7e4cd7f7c3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ed99db2e-2058-41b4-99eb-dff3adfa9403"));

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpDatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    NumberOfOrder = table.Column<int>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrder",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrder", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductOrder_Order_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrder_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_ProductId",
                table: "ProductOrder",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductOrder");

            migrationBuilder.DropTable(
                name: "Order");

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
                    { new Guid("a492a623-c731-4961-9e6f-cd7e4cd7f7c3"), null, new DateTime(2019, 12, 29, 3, 22, 46, 554, DateTimeKind.Utc).AddTicks(1948), "Car", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("83734e7c-dc2f-41ae-88bf-660bcd143cdc"), null, new DateTime(2019, 12, 29, 3, 22, 46, 557, DateTimeKind.Utc).AddTicks(3492), "Shoes", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("ed99db2e-2058-41b4-99eb-dff3adfa9403"), null, new DateTime(2019, 12, 29, 3, 22, 46, 557, DateTimeKind.Utc).AddTicks(3983), "Bike", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("83081a01-0ce2-4225-ba77-ef02fa702577"), null, new DateTime(2019, 12, 29, 3, 22, 46, 557, DateTimeKind.Utc).AddTicks(4075), "Computer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }
    }
}
