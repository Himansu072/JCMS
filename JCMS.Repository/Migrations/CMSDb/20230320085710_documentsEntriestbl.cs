using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JCMS.Repository.Migrations.CMSDb
{
    /// <inheritdoc />
    public partial class documentsEntriestbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "documentsEntries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(29)", maxLength: 29, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documentsEntries", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "documentsEntries");

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

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7066), new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7067), new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7068), new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7069) });
        }
    }
}
