using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JCMS.Repository.Migrations.CMSDb
{
    /// <inheritdoc />
    public partial class documentsEntriestblchange1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "documentsEntries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4588), new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4597), new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4599), new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4622), new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4625), new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4627), new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4659), new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4662), new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4664), new DateTime(2023, 3, 20, 14, 29, 14, 515, DateTimeKind.Local).AddTicks(4664) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "documentsEntries");

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3474), new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3482), new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3501), new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3503), new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3504), new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3523), new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3525), new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3527), new DateTime(2023, 3, 20, 14, 27, 10, 301, DateTimeKind.Local).AddTicks(3528) });
        }
    }
}
