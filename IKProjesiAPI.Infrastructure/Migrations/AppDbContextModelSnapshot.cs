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
                            ConcurrencyStamp = "361afc9c-e596-4eef-a096-c35fc880148c",
                            CreatedDate = new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(4492),
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMİN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "e4e61c75-2355-4daa-9be6-82a60dbbe7a6",
                            CreatedDate = new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(4606),
                            Name = "SiteManager",
                            NormalizedName = "SİTEMANAGER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "cd3e5b6a-8920-47ab-a5c2-f9c31e916145",
                            CreatedDate = new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(4613),
                            Name = "CompanyManager",
                            NormalizedName = "COMPANYMANAGER"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "20a625f2-323d-46d9-9cdf-11b4bc4db740",
                            CreatedDate = new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(4618),
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

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

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
                            ConcurrencyStamp = "55bc369c-504f-44f4-aa2b-6ff7d6a1744b",
                            CreatedDate = new DateTime(2024, 4, 28, 22, 11, 40, 9, DateTimeKind.Local).AddTicks(6319),
                            Email = "super@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Super",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            Password = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAELNQwpwdKsMKRdmPfItlfeAiGEeYcnQa3mvIudwarX18W1Qu5gtiop9nJrq20ITrjg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "486e680c-eb70-4124-b6d1-6b374bd15576",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "71c696d9-09f2-4472-8f92-4ee6991024e6",
                            CreatedDate = new DateTime(2024, 4, 28, 22, 11, 40, 9, DateTimeKind.Local).AddTicks(6341),
                            Email = "companymanager@seeddata.com",
                            EmailConfirmed = false,
                            FirstName = "CompanyManagerName",
                            LastName = "CompanyManagerLastName",
                            LockoutEnabled = false,
                            Password = "companymanager",
                            PasswordHash = "AQAAAAEAACcQAAAAEH+MIur4aFnD3A3T3TNal5YmgfxygYOK0nWIKKZFZlQlcDY2ilmo8m5Gse8zH8q28Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "39cab029-4f18-4e06-b634-7cd1628e92fe",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a65a3722-fc3b-4139-844c-8bc6c7c51273",
                            CreatedDate = new DateTime(2024, 4, 28, 22, 11, 40, 9, DateTimeKind.Local).AddTicks(6336),
                            Email = "sitemanager@seeddata.com",
                            EmailConfirmed = false,
                            FirstName = "SiteManagerName",
                            LastName = "SiteManagerLastName",
                            LockoutEnabled = false,
                            Password = "sitemanager",
                            PasswordHash = "AQAAAAEAACcQAAAAEDgY+PEyXmQQw0NkY7zyncAcrrCr5EaMo0cOlk75exozVHJWuwawwWiqnmFWsRC9BQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4c9e9c90-f470-4c4f-b8f0-2caf908927ba",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c004f83f-7b2f-4d41-a5e7-60ff23c9c027",
                            CreatedDate = new DateTime(2024, 4, 28, 22, 11, 40, 9, DateTimeKind.Local).AddTicks(6359),
                            Email = "employee@seeddata.com",
                            EmailConfirmed = false,
                            FirstName = "EmployeeName",
                            LastName = "EmployeeLastName",
                            LockoutEnabled = false,
                            Password = "employee",
                            PasswordHash = "AQAAAAEAACcQAAAAELzunx64f8GsR3I3aG0MJVFI/Lj8CwarQvOKmUsU2q5V9redT6J91VwfA3Vk/eo9Nw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a3128e31-0226-43b1-914b-2bd1183c6648",
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
                            CreatedDate = new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(5035),
                            Status = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2,
                            CreatedDate = new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(5045),
                            Status = 1
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 3,
                            CreatedDate = new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(5047),
                            Status = 1
                        },
                        new
                        {
                            UserId = 4,
                            RoleId = 4,
                            CreatedDate = new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(5049),
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
                            CreatedDate = new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(5553)
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

            modelBuilder.Entity("IKProjesiAPI.Domain.Entities.Company", b =>
                {
                    b.Navigation("CompanyManagers");
                });
#pragma warning restore 612, 618
        }
    }
}
