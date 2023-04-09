using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JCMS.Repository.Migrations.CMSDb
{
    /// <inheritdoc />
    public partial class newstblcreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PageSection");

            migrationBuilder.CreateTable(
                name: "NewsEvents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsEvents", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsEvents");

            migrationBuilder.CreateTable(
                name: "PageSection",
                columns: table => new
                {
                    PsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sectiontype = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageSection", x => x.PsId);
                    table.ForeignKey(
                        name: "FK_PageSection_PageMaster_PageId",
                        column: x => x.PageId,
                        principalTable: "PageMaster",
                        principalColumn: "Pid",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PageSection_PageId",
                table: "PageSection",
                column: "PageId");
        }
    }
}
