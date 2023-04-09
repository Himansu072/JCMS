using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JCMS.Repository.Migrations.CMSDb
{
    /// <inheritdoc />
    public partial class services : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageNmae = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_PublicUtilityCategory_CatId",
                        column: x => x.CatId,
                        principalTable: "PublicUtilityCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Service_CatId",
                table: "Service",
                column: "CatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5135), new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5137), new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5153), new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Council",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5155) });
        }
    }
}
