using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JCMS.Repository.Migrations.CMSDb
{
    /// <inheritdoc />
    public partial class ataglance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AtaGlances",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtaGlances", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4341), new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4346), new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4347), new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4366), new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4368), new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4369), new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4384), new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4385), new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4386), new DateTime(2023, 3, 26, 12, 41, 21, 61, DateTimeKind.Local).AddTicks(4386) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtaGlances");

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
    }
}
