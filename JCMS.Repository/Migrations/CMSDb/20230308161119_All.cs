using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JCMS.Repository.Migrations.CMSDb
{
    /// <inheritdoc />
    public partial class All : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announcement",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Council",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Councilname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Council", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistrictAdministration",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: true),
                    Imagepath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedMainPage = table.Column<int>(type: "int", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistrictAdministration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExecutiveOfficers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    photo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mobileno = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeriodFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExecutiveOfficers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    linkIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuType = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    languageType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageMaster",
                columns: table => new
                {
                    Pid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveStatus = table.Column<bool>(type: "bit", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageMaster", x => x.Pid);
                });

            migrationBuilder.CreateTable(
                name: "programeCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CategoryContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_programeCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tender",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titleen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    openingDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    openingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    closingDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    closeingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    subDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    subTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UploadImages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Videolink = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    type = table.Column<int>(type: "int", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ward",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wardname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublicUtilityCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CattypeId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicUtilityCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublicUtilityCategory_CategoryType_CattypeId",
                        column: x => x.CattypeId,
                        principalTable: "CategoryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Councilers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Councilid = table.Column<long>(type: "bigint", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mobileno = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeriodFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Councilers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Councilers_Council_Councilid",
                        column: x => x.Councilid,
                        principalTable: "Council",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pid = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActiveStatus = table.Column<bool>(type: "bit", nullable: false),
                    languageType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Page_PageMaster_Pid",
                        column: x => x.Pid,
                        principalTable: "PageMaster",
                        principalColumn: "Pid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PageSection",
                columns: table => new
                {
                    PsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sectiontype = table.Column<int>(type: "int", nullable: false),
                    PageId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "WardOfficers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Wardid = table.Column<long>(type: "bigint", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mobileno = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeriodFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WardOfficers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WardOfficers_Ward_Wardid",
                        column: x => x.Wardid,
                        principalTable: "Ward",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PublicUtility",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatId = table.Column<long>(type: "bigint", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<int>(type: "int", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicUtility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublicUtility_PublicUtilityCategory_CatId",
                        column: x => x.CatId,
                        principalTable: "PublicUtilityCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryType",
                columns: new[] { "Id", "AddedDate", "Deleted", "DeletedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5130), 0, null, new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5131), "PublicUtility" },
                    { 2L, new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5135), 0, null, new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5136), "Services" },
                    { 3L, new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5137), 0, null, new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5138), "Documents" }
                });

            migrationBuilder.InsertData(
                table: "Council",
                columns: new[] { "Id", "AddedDate", "Councilname", "Deleted", "DeletedDate", "ModifiedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5151), "Council1", 0, null, new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5151) },
                    { 2L, new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5153), "Council2", 0, null, new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5153) },
                    { 3L, new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5154), "Council3", 0, null, new DateTime(2023, 3, 8, 21, 41, 19, 65, DateTimeKind.Local).AddTicks(5155) }
                });

            migrationBuilder.InsertData(
                table: "PageMaster",
                columns: new[] { "Pid", "ActiveStatus", "AddedOn", "MetaDescription", "MetaKeyword", "MetaTitle", "Name", "Url" },
                values: new object[,]
                {
                    { 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "AboutUs", null },
                    { 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Mission", null },
                    { 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Demography", null },
                    { 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "RTI", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Councilers_Councilid",
                table: "Councilers",
                column: "Councilid");

            migrationBuilder.CreateIndex(
                name: "IX_Page_Pid",
                table: "Page",
                column: "Pid");

            migrationBuilder.CreateIndex(
                name: "IX_PageSection_PageId",
                table: "PageSection",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicUtility_CatId",
                table: "PublicUtility",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicUtilityCategory_CattypeId",
                table: "PublicUtilityCategory",
                column: "CattypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WardOfficers_Wardid",
                table: "WardOfficers",
                column: "Wardid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcement");

            migrationBuilder.DropTable(
                name: "Councilers");

            migrationBuilder.DropTable(
                name: "DistrictAdministration");

            migrationBuilder.DropTable(
                name: "ExecutiveOfficers");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "PageSection");

            migrationBuilder.DropTable(
                name: "programeCategories");

            migrationBuilder.DropTable(
                name: "PublicUtility");

            migrationBuilder.DropTable(
                name: "Tender");

            migrationBuilder.DropTable(
                name: "UploadImages");

            migrationBuilder.DropTable(
                name: "WardOfficers");

            migrationBuilder.DropTable(
                name: "Council");

            migrationBuilder.DropTable(
                name: "PageMaster");

            migrationBuilder.DropTable(
                name: "PublicUtilityCategory");

            migrationBuilder.DropTable(
                name: "Ward");

            migrationBuilder.DropTable(
                name: "CategoryType");
        }
    }
}
