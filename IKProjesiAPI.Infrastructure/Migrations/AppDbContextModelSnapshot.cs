﻿// <auto-generated />
using System;
using IKProjesiAPI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.AppEntities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "43f9e5e9-dbb7-4cdd-aab8-5bd6c7a02874",
                            CreatedDate = new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(8609),
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMİN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "00d24a7f-a2eb-4661-a131-f6c88e337c19",
                            CreatedDate = new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(8697),
                            Name = "SiteManager",
                            NormalizedName = "SİTEMANAGER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "6af00890-d976-4b2e-9625-721858188fca",
                            CreatedDate = new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(8705),
                            Name = "CompanyManager",
                            NormalizedName = "COMPANYMANAGER"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "9ec3e6eb-941b-4a04-bdfe-90e29572405b",
                            CreatedDate = new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(8717),
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        });
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.AppEntities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.AppEntities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentName")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FinishDateOfWork")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ImageBytes")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("JobName")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecondLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDateOfWork")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("AppUser");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2dceadc5-17c7-447c-b2ce-08bf446c21de",
                            CreatedDate = new DateTime(2024, 4, 30, 10, 54, 58, 696, DateTimeKind.Local).AddTicks(1523),
                            Email = "super@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Super",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            Password = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEPcXG1OHlm4Cw6LYNzZ1ZpAYIZRofMXB+LCpVHPotYNxuMq1v7kiMj3VNBiC/ouQ9w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "02b90a5f-72a8-47a6-9676-a452c52473c1",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f0f4d6c3-4f39-4f74-8140-179fdb315c1f",
                            CreatedDate = new DateTime(2024, 4, 30, 10, 54, 58, 696, DateTimeKind.Local).AddTicks(1590),
                            Email = "companymanager@seeddata.com",
                            EmailConfirmed = false,
                            FirstName = "CompanyManagerName",
                            LastName = "CompanyManagerLastName",
                            LockoutEnabled = false,
                            Password = "companymanager",
                            PasswordHash = "AQAAAAEAACcQAAAAEEDd30IEgaEfQazIpLn1EIuaUTBs4Mq+jDcIm8DWP+Dp++nWgHPzmtV+WklpEdvlOA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "af261dd6-a116-4c80-b134-197f5a360989",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0bf9997d-be2e-4e70-9735-8190593b455a",
                            CreatedDate = new DateTime(2024, 4, 30, 10, 54, 58, 696, DateTimeKind.Local).AddTicks(1551),
                            Email = "sitemanager@seeddata.com",
                            EmailConfirmed = false,
                            FirstName = "SiteManagerName",
                            LastName = "SiteManagerLastName",
                            LockoutEnabled = false,
                            Password = "sitemanager",
                            PasswordHash = "AQAAAAEAACcQAAAAEPZoFNweYf6l06sTIybxuNV9HFN3XSFTJwakRB9rgj8a1FxnMyT2fEr1wCSvYZGtMw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "be749c89-f04a-46e1-a75f-e879cc8282d2",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1a2dfc6b-dce6-4223-ab60-44897c01e457",
                            CreatedDate = new DateTime(2024, 4, 30, 10, 54, 58, 696, DateTimeKind.Local).AddTicks(1596),
                            Email = "employee@seeddata.com",
                            EmailConfirmed = false,
                            FirstName = "EmployeeName",
                            LastName = "EmployeeLastName",
                            LockoutEnabled = false,
                            Password = "employee",
                            PasswordHash = "AQAAAAEAACcQAAAAEFDETfPXtRFf3FLSPyTmd6XES6a2Zc728XbEBYGLsryE229MsbQUeMW8pwMjyaayyQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "96d63bfe-6c69-4ec6-aa2c-61cf0fbe31ed",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.AppEntities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.AppEntities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.AppEntities.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1,
                            CreatedDate = new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(9206),
                            Status = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2,
                            CreatedDate = new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(9217),
                            Status = 1
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 3,
                            CreatedDate = new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(9221),
                            Status = 1
                        },
                        new
                        {
                            UserId = 4,
                            RoleId = 4,
                            CreatedDate = new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(9223),
                            Status = 1
                        });
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.AppEntities.AppUserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyTaxNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyTaxOffice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndContractDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FoundationYear")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("LogoBytes")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("MersisNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartContractDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Company",
                            CreatedDate = new DateTime(2024, 4, 30, 10, 54, 58, 725, DateTimeKind.Local).AddTicks(117)
                        });
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.TemporaryPassword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("NewPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("TemporaryPassword");
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.CompanyManager", b =>
                {
                    b.HasBaseType("IKProjesiAPI.Domain.Entities.AppEntities.AppUser");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.HasIndex("CompanyId");

                    b.HasDiscriminator().HasValue("CompanyManager");
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.Personel", b =>
                {
                    b.HasBaseType("IKProjesiAPI.Domain.Entities.AppEntities.AppUser");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int")
                        .HasColumnName("Personel_CompanyId");

                    b.HasIndex("CompanyId");

                    b.HasDiscriminator().HasValue("Personel");
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.SiteManager", b =>
                {
                    b.HasBaseType("IKProjesiAPI.Domain.Entities.AppEntities.AppUser");

                    b.HasDiscriminator().HasValue("SiteManager");
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.AppEntities.AppRoleClaim", b =>
                {
                    b.HasOne("IKProjesiAPI.Domain.Entities.AppEntities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.AppEntities.AppUserClaim", b =>
                {
                    b.HasOne("IKProjesiAPI.Domain.Entities.AppEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.AppEntities.AppUserLogin", b =>
                {
                    b.HasOne("IKProjesiAPI.Domain.Entities.AppEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.AppEntities.AppUserRole", b =>
                {
                    b.HasOne("IKProjesiAPI.Domain.Entities.AppEntities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IKProjesiAPI.Domain.Entities.AppEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.AppEntities.AppUserToken", b =>
                {
                    b.HasOne("IKProjesiAPI.Domain.Entities.AppEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.TemporaryPassword", b =>
                {
                    b.HasOne("IKProjesiAPI.Domain.Entities.AppEntities.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.CompanyManager", b =>
                {
                    b.HasOne("IKProjesiAPI.Domain.Entities.Company", "Company")
                        .WithMany("CompanyManagers")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.Personel", b =>
                {
                    b.HasOne("IKProjesiAPI.Domain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.Company", b =>
                {
                    b.Navigation("CompanyManagers");
                });
#pragma warning restore 612, 618
        }
    }
}
