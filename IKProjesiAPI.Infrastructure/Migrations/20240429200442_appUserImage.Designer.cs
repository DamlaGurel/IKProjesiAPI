﻿// <auto-generated />
using System;
using IKProjesiAPI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240429200442_appUserImage")]
    partial class appUserImage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "b891c4b6-4b86-4f3f-be5c-d620dfbc7d71",
                            CreatedDate = new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(8513),
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMİN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "e763e72c-1ac8-4fcb-9df7-350742226bce",
                            CreatedDate = new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(8619),
                            Name = "SiteManager",
                            NormalizedName = "SİTEMANAGER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "833eaddc-1be7-41e0-815f-0d6bb63804d9",
                            CreatedDate = new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(8640),
                            Name = "CompanyManager",
                            NormalizedName = "COMPANYMANAGER"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "8210545f-9b22-4450-85f2-f9c20adea728",
                            CreatedDate = new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(8658),
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
                            ConcurrencyStamp = "44a6fedf-9053-45dd-b35e-2864cc1688ad",
                            CreatedDate = new DateTime(2024, 4, 29, 23, 4, 41, 232, DateTimeKind.Local).AddTicks(4969),
                            Email = "super@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Super",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            Password = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEFpRK//LEImwBrH997Zxofk86bZUxlh1xarAgFztSYSeTJoVcf/7WnZD1/fOcObIIw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cb40b178-19ba-4bc4-af2d-1b89544c725b",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3b2ff46f-5919-453a-911a-f638c569a5f6",
                            CreatedDate = new DateTime(2024, 4, 29, 23, 4, 41, 232, DateTimeKind.Local).AddTicks(5135),
                            Email = "companymanager@seeddata.com",
                            EmailConfirmed = false,
                            FirstName = "CompanyManagerName",
                            LastName = "CompanyManagerLastName",
                            LockoutEnabled = false,
                            Password = "companymanager",
                            PasswordHash = "AQAAAAEAACcQAAAAEIb7A9F5ymjDWCn/Qo3NiDOGbamx38HgfJMK+DRtTNFthApXOK3BDnYDKvL9F7M/SA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "db828cab-752b-4b3f-8344-7fac7d6f3ec4",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "35edcede-10f6-4f5c-bebb-a7ff1fab4e39",
                            CreatedDate = new DateTime(2024, 4, 29, 23, 4, 41, 232, DateTimeKind.Local).AddTicks(5022),
                            Email = "sitemanager@seeddata.com",
                            EmailConfirmed = false,
                            FirstName = "SiteManagerName",
                            LastName = "SiteManagerLastName",
                            LockoutEnabled = false,
                            Password = "sitemanager",
                            PasswordHash = "AQAAAAEAACcQAAAAEBlcrwnV909WwauqvMglxCRytW9boQniZGEopEs0xcJ+Q2hwVVw+y8tyKSw6d6k/og==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4d5af208-4638-4204-941f-5bd276a49277",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c36f792c-0ac3-4ea0-b9da-d1294f786e80",
                            CreatedDate = new DateTime(2024, 4, 29, 23, 4, 41, 232, DateTimeKind.Local).AddTicks(5161),
                            Email = "employee@seeddata.com",
                            EmailConfirmed = false,
                            FirstName = "EmployeeName",
                            LastName = "EmployeeLastName",
                            LockoutEnabled = false,
                            Password = "employee",
                            PasswordHash = "AQAAAAEAACcQAAAAEMLN8gp/fybQkp1ghFxkjz+jTAVZ7K0wT7eCbpNyd/gN1uhBkQVcExTLPuD9+SwSNA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9c7247ce-6adb-48cc-9ad8-2f7e6ccb709c",
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
                            CreatedDate = new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(9818),
                            Status = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2,
                            CreatedDate = new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(9847),
                            Status = 1
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 3,
                            CreatedDate = new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(9855),
                            Status = 1
                        },
                        new
                        {
                            UserId = 4,
                            RoleId = 4,
                            CreatedDate = new DateTime(2024, 4, 29, 23, 4, 41, 308, DateTimeKind.Local).AddTicks(68),
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
                            CreatedDate = new DateTime(2024, 4, 29, 23, 4, 41, 308, DateTimeKind.Local).AddTicks(1556)
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

                    b.Property<string>("Password")
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
