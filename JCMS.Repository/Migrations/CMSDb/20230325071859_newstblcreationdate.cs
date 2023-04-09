using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JCMS.Repository.Migrations.CMSDb
{
    /// <inheritdoc />
    public partial class newstblcreationdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Eventdate",
                table: "NewsEvents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4503), new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4507), new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4509), new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4525), new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4527), new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4529), new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4959), new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4961), new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4963), new DateTime(2023, 3, 25, 12, 48, 58, 857, DateTimeKind.Local).AddTicks(4964) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eventdate",
                table: "NewsEvents");

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5120), new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5126), new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5167), new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5229), new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5236), new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5241), new DateTime(2023, 3, 25, 10, 51, 23, 514, DateTimeKind.Local).AddTicks(5252) });
        }
    }
}
