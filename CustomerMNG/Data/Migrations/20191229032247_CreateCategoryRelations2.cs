using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMNG.Data.Migrations
{
    public partial class CreateCategoryRelations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("02200c33-feb5-4002-81dc-20fa2c6e92c5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a99bd2a9-5857-4ce5-b180-94c7bea2cd81"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b8c8cdf8-a9c4-49e6-b59d-d2b03901c492"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpDatedDate", "UpdatedBy" },
                values: new object[] { new Guid("b8c8cdf8-a9c4-49e6-b59d-d2b03901c492"), null, new DateTime(2019, 12, 29, 3, 2, 50, 772, DateTimeKind.Utc).AddTicks(9832), "Car", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpDatedDate", "UpdatedBy" },
                values: new object[] { new Guid("02200c33-feb5-4002-81dc-20fa2c6e92c5"), null, new DateTime(2019, 12, 29, 3, 2, 50, 774, DateTimeKind.Utc).AddTicks(8978), "Shoes", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpDatedDate", "UpdatedBy" },
                values: new object[] { new Guid("a99bd2a9-5857-4ce5-b180-94c7bea2cd81"), null, new DateTime(2019, 12, 29, 3, 2, 50, 774, DateTimeKind.Utc).AddTicks(9195), "Bike", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }
    }
}
