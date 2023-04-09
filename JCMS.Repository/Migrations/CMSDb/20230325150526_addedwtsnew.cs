using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JCMS.Repository.Migrations.CMSDb
{
    /// <inheritdoc />
    public partial class addedwtsnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "iswtsnew",
                table: "Tender",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "iswtsnew",
                table: "NewsEvents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "iswtsnew",
                table: "documentsEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "iswtsnew",
                table: "Announcement",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1631), new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1637), new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1639), new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1652), new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1654), new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1656), new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1675), new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1676), new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1678), new DateTime(2023, 3, 25, 20, 35, 26, 119, DateTimeKind.Local).AddTicks(1679) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "iswtsnew",
                table: "Tender");

            migrationBuilder.DropColumn(
                name: "iswtsnew",
                table: "NewsEvents");

            migrationBuilder.DropColumn(
                name: "iswtsnew",
                table: "documentsEntries");

            migrationBuilder.DropColumn(
                name: "iswtsnew",
                table: "Announcement");

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
    }
}
