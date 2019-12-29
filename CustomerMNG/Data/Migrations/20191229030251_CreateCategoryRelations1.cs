using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMNG.Data.Migrations
{
    public partial class CreateCategoryRelations1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
