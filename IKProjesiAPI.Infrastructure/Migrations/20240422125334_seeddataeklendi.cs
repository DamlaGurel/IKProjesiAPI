using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class seeddataeklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Company_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartContractDate",
                table: "Companies",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MersisNumber",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FoundationYear",
                table: "Companies",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndContractDate",
                table: "Companies",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeNumber",
                table: "Companies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyTitle",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyTaxOffice",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyTaxNumber",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "c0d1b328-76ee-4eff-ae08-02925484ea24", new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "251fe14c-abf1-4978-b11d-dcb8fc56bd43", new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "418ba0db-3e9c-44c3-923b-e90bb2120f5d", new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "e78ca60e-e754-4e07-a6ff-7fdbcf724f92", new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42ef1643-7ee4-43c3-ae7a-5c7b198eafce", new DateTime(2024, 4, 22, 15, 53, 33, 738, DateTimeKind.Local).AddTicks(2780), "AQAAAAIAAYagAAAAEHx83aCzK6pQCQzNaso4bCWzP0F6k5KGZH04prvH+worw9yVxx7OhdGJSn56pixxzw==", "ca8c53f6-a5b6-4737-8e2a-7710bd190c05" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthPlace", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "DepartmentName", "Discriminator", "Email", "EmailConfirmed", "FinishDateOfWork", "FirstName", "IdentityNumber", "ImagePath", "JobName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecondLastName", "SecondName", "SecurityStamp", "StartDateOfWork", "Status", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 2, 0, null, null, null, "e16b17ba-a795-4c07-822e-2a37e3b0951c", new DateTime(2024, 4, 22, 15, 53, 33, 738, DateTimeKind.Local).AddTicks(2830), null, null, "AppUser", "sitemanager@seeddata.com", false, null, "SiteManagerName", null, null, null, "SiteManagerLastName", false, null, null, null, "sitemanager", "AQAAAAIAAYagAAAAEP/g+TyhXCWmfNPIfvCGJ6G+VJc+tdMPGzImjpypBP4dfmiiTWy9lpFOtgFF2zAZkA==", null, false, null, null, "aa38ad39-30b6-4c35-a0d7-ce0511b8d91c", null, null, false, null, null },
                    { 3, 0, null, null, null, "02a0a89c-71b7-4dca-be86-6d0e312f6774", new DateTime(2024, 4, 22, 15, 53, 33, 738, DateTimeKind.Local).AddTicks(2840), null, null, "AppUser", "companymanager@seeddata.com", false, null, "CompanyManagerName", null, null, null, "CompanyManagerLastName", false, null, null, null, "companymanager", "AQAAAAIAAYagAAAAEIYx2g8bVezU81QcWlWZVARNUIbF3b/nxLJv9qBr4cG0VwUXH5jV+Rl49zneZU2OOQ==", null, false, null, null, "71304627-26d2-4346-91a6-6401f1534fb3", null, null, false, null, null },
                    { 4, 0, null, null, null, "ecebd16b-dfd7-4b05-8682-41771d81d490", new DateTime(2024, 4, 22, 15, 53, 33, 738, DateTimeKind.Local).AddTicks(2850), null, null, "AppUser", "employee@seeddata.com", false, null, "EmployeeName", null, null, null, "EmployeeLastName", false, null, null, null, "employee", "AQAAAAIAAYagAAAAEHB3N9VvClYB0TWcsX5c9zntl5hSdrarmFY8tD49qjoq3oMpemFY7TNvCsaZ0SXycw==", null, false, null, null, "5e256dbf-969a-4a1d-adae-cb06ef9207b2", null, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CompanyName", "CompanyTaxNumber", "CompanyTaxOffice", "CompanyTitle", "CreatedDate", "DeletedDate", "Email", "EmployeeNumber", "EndContractDate", "FoundationYear", "MersisNumber", "PhoneNumber", "StartContractDate", "Status", "UpdatedDate" },
                values: new object[] { 1, null, "Company", null, null, null, new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(4390), null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "CreatedDate", "DeletedDate", "Discriminator", "Status", "UpdatedDate" },
                values: new object[] { 2, 2, new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(4100), null, "AppUserRole", 1, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "CreatedDate", "DeletedDate", "Discriminator", "Status", "UpdatedDate" },
                values: new object[] { 3, 3, new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(4110), null, "AppUserRole", 1, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "CreatedDate", "DeletedDate", "Discriminator", "Status", "UpdatedDate" },
                values: new object[] { 4, 4, new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(4110), null, "AppUserRole", 1, null });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartContractDate",
                table: "Company",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MersisNumber",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FoundationYear",
                table: "Company",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndContractDate",
                table: "Company",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeNumber",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Company",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyTitle",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyTaxOffice",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyTaxNumber",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "31dcc273-4855-4763-9989-583c92e12985", new DateTime(2024, 4, 22, 1, 56, 27, 200, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "17f38760-a001-403e-94c2-5a994170ad56", new DateTime(2024, 4, 22, 1, 56, 27, 200, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5ffee499-6b0d-4dc9-9340-1551c8a31734", new DateTime(2024, 4, 22, 1, 56, 27, 200, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "b36db89d-fa27-4f9f-8a1a-ea153e63f7ac", new DateTime(2024, 4, 22, 1, 56, 27, 200, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 1, 56, 27, 200, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7e39f4f-7e7e-424b-b4f1-b5652309dd89", new DateTime(2024, 4, 22, 1, 56, 27, 192, DateTimeKind.Local).AddTicks(7439), "AQAAAAEAACcQAAAAELctk/rKJtHhJp1b6n4KBBZfNkoXQVNauAebCrO/0THN9fYCctZBcHMf2ycRJVUtqw==", "6d116ad6-a9a2-45c0-b619-a0cc742e08f4" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Company_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
