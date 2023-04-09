using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JCMS.Repository.Migrations.CMSDb
{
    /// <inheritdoc />
    public partial class columnfortbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "caption",
                table: "UploadImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7034), new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7039), new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7040), new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7052), new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7053), new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7055), new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "AddedDate", "Deleted", "DeletedDate", "ModifiedDate", "Wardname" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7066), 0, null, new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7066), "Ward-1" },
                    { 2L, new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7067), 0, null, new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7067), "Ward-2" },
                    { 3L, new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7068), 0, null, new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7069), "Ward-3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DropColumn(
                name: "caption",
                table: "UploadImages");

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 22, 35, 54, 626, DateTimeKind.Local).AddTicks(4018), new DateTime(2023, 3, 14, 22, 35, 54, 626, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 22, 35, 54, 626, DateTimeKind.Local).AddTicks(4023), new DateTime(2023, 3, 14, 22, 35, 54, 626, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 22, 35, 54, 626, DateTimeKind.Local).AddTicks(4025), new DateTime(2023, 3, 14, 22, 35, 54, 626, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 22, 35, 54, 626, DateTimeKind.Local).AddTicks(4038), new DateTime(2023, 3, 14, 22, 35, 54, 626, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 22, 35, 54, 626, DateTimeKind.Local).AddTicks(4039), new DateTime(2023, 3, 14, 22, 35, 54, 626, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 14, 22, 35, 54, 626, DateTimeKind.Local).AddTicks(4041), new DateTime(2023, 3, 14, 22, 35, 54, 626, DateTimeKind.Local).AddTicks(4041) });
        }
    }
}
