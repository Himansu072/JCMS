﻿// <auto-generated />
using System;
using JCMS.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JCMS.Repository.Migrations.CMSDb
{
    [DbContext(typeof(CMSDbContext))]
    [Migration("20230316182852_columnfortbl")]
    partial class columnfortbl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JCMS.Model.Entities.CategoryType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoryType");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AddedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7034),
                            Deleted = 0,
                            ModifiedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7034),
                            Name = "PublicUtility"
                        },
                        new
                        {
                            Id = 2L,
                            AddedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7039),
                            Deleted = 0,
                            ModifiedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7039),
                            Name = "Services"
                        },
                        new
                        {
                            Id = 3L,
                            AddedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7040),
                            Deleted = 0,
                            ModifiedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7041),
                            Name = "Documents"
                        });
                });

            modelBuilder.Entity("JCMS.Model.Entities.Documents.Announcement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Announcement");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Documents.Tender", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titleen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("closeingTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("closingDt")
                        .HasColumnType("datetime2");

                    b.Property<string>("fileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("openingDt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("openingTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("subDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("subTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tender");
                });

            modelBuilder.Entity("JCMS.Model.Entities.MainPage.DistrictAdministration", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(65)
                        .HasColumnType("nvarchar(65)");

                    b.Property<string>("Imagepath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("PublishedMainPage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DistrictAdministration");
                });

            modelBuilder.Entity("JCMS.Model.Entities.MainPage.UploadImages", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Videolink")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UploadImages");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Master.Council", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Councilname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Council");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AddedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7052),
                            Councilname = "Council1",
                            Deleted = 0,
                            ModifiedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7052)
                        },
                        new
                        {
                            Id = 2L,
                            AddedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7053),
                            Councilname = "Council2",
                            Deleted = 0,
                            ModifiedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7054)
                        },
                        new
                        {
                            Id = 3L,
                            AddedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7055),
                            Councilname = "Council3",
                            Deleted = 0,
                            ModifiedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7055)
                        });
                });

            modelBuilder.Entity("JCMS.Model.Entities.Master.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MenuType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("languageType")
                        .HasColumnType("int");

                    b.Property<string>("linkIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Master.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pid")
                        .HasColumnType("int");

                    b.Property<int>("languageType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Pid");

                    b.ToTable("Page");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Master.PageMaster", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Pid"));

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("MetaDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaKeyword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pid");

                    b.ToTable("PageMaster");

                    b.HasData(
                        new
                        {
                            Pid = 1,
                            ActiveStatus = false,
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "AboutUs"
                        },
                        new
                        {
                            Pid = 2,
                            ActiveStatus = false,
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mission"
                        },
                        new
                        {
                            Pid = 3,
                            ActiveStatus = false,
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Demography"
                        },
                        new
                        {
                            Pid = 4,
                            ActiveStatus = false,
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "RTI"
                        });
                });

            modelBuilder.Entity("JCMS.Model.Entities.Master.PageSection", b =>
                {
                    b.Property<int>("PsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PsId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PageId")
                        .HasColumnType("int");

                    b.Property<int>("Sectiontype")
                        .HasColumnType("int");

                    b.HasKey("PsId");

                    b.HasIndex("PageId");

                    b.ToTable("PageSection");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Master.ProgrameCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CategoryContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("programeCategories");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Master.Ward", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Wardname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ward");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AddedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7066),
                            Deleted = 0,
                            ModifiedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7066),
                            Wardname = "Ward-1"
                        },
                        new
                        {
                            Id = 2L,
                            AddedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7067),
                            Deleted = 0,
                            ModifiedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7067),
                            Wardname = "Ward-2"
                        },
                        new
                        {
                            Id = 3L,
                            AddedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7068),
                            Deleted = 0,
                            ModifiedDate = new DateTime(2023, 3, 16, 23, 58, 51, 952, DateTimeKind.Local).AddTicks(7069),
                            Wardname = "Ward-3"
                        });
                });

            modelBuilder.Entity("JCMS.Model.Entities.Officials.Counciler", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("Councilid")
                        .HasColumnType("bigint");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobileno")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("PeriodFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PeriodTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Councilid");

                    b.ToTable("Councilers");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Officials.ExecutiveOfficer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobileno")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("PeriodFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PeriodTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ExecutiveOfficers");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Officials.WardOfficers", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobileno")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("PeriodFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PeriodTo")
                        .HasColumnType("datetime2");

                    b.Property<long>("Wardid")
                        .HasColumnType("bigint");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Wardid");

                    b.ToTable("WardOfficers");
                });

            modelBuilder.Entity("JCMS.Model.Entities.PublicUtilities.PublicUtility", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CatId")
                        .HasColumnType("bigint");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatId");

                    b.ToTable("PublicUtility");
                });

            modelBuilder.Entity("JCMS.Model.Entities.PublicUtilities.PublicUtilityCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CattypeId")
                        .HasColumnType("bigint");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CattypeId");

                    b.ToTable("PublicUtilityCategory");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Services", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("CatId")
                        .HasColumnType("bigint");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageNmae")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Master.Page", b =>
                {
                    b.HasOne("JCMS.Model.Entities.Master.PageMaster", "PageMaster")
                        .WithMany()
                        .HasForeignKey("Pid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PageMaster");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Master.PageSection", b =>
                {
                    b.HasOne("JCMS.Model.Entities.Master.PageMaster", "PageMaster")
                        .WithMany()
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PageMaster");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Officials.Counciler", b =>
                {
                    b.HasOne("JCMS.Model.Entities.Master.Council", "Council")
                        .WithMany()
                        .HasForeignKey("Councilid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Council");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Officials.WardOfficers", b =>
                {
                    b.HasOne("JCMS.Model.Entities.Master.Ward", "Ward")
                        .WithMany()
                        .HasForeignKey("Wardid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ward");
                });

            modelBuilder.Entity("JCMS.Model.Entities.PublicUtilities.PublicUtility", b =>
                {
                    b.HasOne("JCMS.Model.Entities.PublicUtilities.PublicUtilityCategory", "PublicUtilityCategory")
                        .WithMany()
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PublicUtilityCategory");
                });

            modelBuilder.Entity("JCMS.Model.Entities.PublicUtilities.PublicUtilityCategory", b =>
                {
                    b.HasOne("JCMS.Model.Entities.CategoryType", "CategoryType")
                        .WithMany()
                        .HasForeignKey("CattypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryType");
                });

            modelBuilder.Entity("JCMS.Model.Entities.Services", b =>
                {
                    b.HasOne("JCMS.Model.Entities.PublicUtilities.PublicUtilityCategory", "PublicUtilityCategory")
                        .WithMany()
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PublicUtilityCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
