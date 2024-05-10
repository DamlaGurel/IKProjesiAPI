using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class rolNameUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Payment",
                table: "AdvancePayments",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Name", "NormalizedName" },
                values: new object[] { "e9c5dd1a-b8aa-43b2-a599-a617f6ce4c79", new DateTime(2024, 5, 10, 14, 43, 58, 894, DateTimeKind.Local).AddTicks(9652), "SUPERADMIN", "SUPERADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Name", "NormalizedName" },
                values: new object[] { "83f5594b-c853-47f8-a839-72364f329afa", new DateTime(2024, 5, 10, 14, 43, 58, 894, DateTimeKind.Local).AddTicks(9678), "SITEMANAGER", "SITEMANAGER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Name" },
                values: new object[] { "5b8c8b6e-90c9-4d87-acfa-ef7d524cf451", new DateTime(2024, 5, 10, 14, 43, 58, 894, DateTimeKind.Local).AddTicks(9756), "COMPANYMANAGER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Name" },
                values: new object[] { "5498e6cf-52a8-4913-b00f-aa86d0a39411", new DateTime(2024, 5, 10, 14, 43, 58, 894, DateTimeKind.Local).AddTicks(9766), "EMPLOYEE" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 14, 43, 58, 895, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 14, 43, 58, 895, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 14, 43, 58, 895, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 14, 43, 58, 895, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b6c4c4c-4116-4848-b10b-7df9c565fd95", new DateTime(2024, 5, 10, 14, 43, 58, 865, DateTimeKind.Local).AddTicks(309), "AQAAAAEAACcQAAAAELA7wORbIiws01VykkESw1xSP1bEi2pcCFxZmN8MomK/pMsK8iWjzin2LTFj7TaifQ==", "8d781dab-3327-47b4-950b-f5dbafc87ee6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aba0440-78d2-429c-b306-0fddbc732cb7", new DateTime(2024, 5, 10, 14, 43, 58, 865, DateTimeKind.Local).AddTicks(327), "AQAAAAEAACcQAAAAELg7rjiclElhpQ9CDANg4zfcIDAGD4ay6GXGbeDVUS7y1+1RlYg0jWJUNdGUq7t4BA==", "69c584d8-e8f4-4b7b-a63e-cc0ef2e670d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20fdf1d9-e18c-439f-9af0-6f94411a0407", new DateTime(2024, 5, 10, 14, 43, 58, 865, DateTimeKind.Local).AddTicks(333), "AQAAAAEAACcQAAAAEKyGYFtB3IhJ8NTwoT2ZeU71wjW5EZwSmYvI/2XKtT5W0GlqBikCGH5dG/fG/xejWg==", "124020fc-a2ca-4600-937a-b1773ce87e0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b335308b-c83e-4874-8135-d7edc999b92c", new DateTime(2024, 5, 10, 14, 43, 58, 865, DateTimeKind.Local).AddTicks(338), "AQAAAAEAACcQAAAAEKHs63QsDgCwbKX4IkDJyCPJ3TQLzv/q2ZkAO4FDNsQMTjCOUbsyaa6IlmbjgqFisg==", "db668888-69e8-40ed-a08e-06ae2daab371" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 14, 43, 58, 895, DateTimeKind.Local).AddTicks(3072));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Payment",
                table: "AdvancePayments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Name", "NormalizedName" },
                values: new object[] { "da02a98c-c597-4566-bc1e-e0e5285ba149", new DateTime(2024, 5, 3, 20, 53, 8, 661, DateTimeKind.Local).AddTicks(4122), "SuperAdmin", "SUPERADMİN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Name", "NormalizedName" },
                values: new object[] { "01b6e43d-7ca0-4ae4-af2c-3f05e549b199", new DateTime(2024, 5, 3, 20, 53, 8, 661, DateTimeKind.Local).AddTicks(4173), "SiteManager", "SİTEMANAGER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Name" },
                values: new object[] { "08f2da98-9b8b-43b6-8fb2-c9136a9309f1", new DateTime(2024, 5, 3, 20, 53, 8, 661, DateTimeKind.Local).AddTicks(4189), "CompanyManager" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Name" },
                values: new object[] { "f0d7b3a2-b996-4bd9-a960-fda02b1935a8", new DateTime(2024, 5, 3, 20, 53, 8, 661, DateTimeKind.Local).AddTicks(4196), "Employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 20, 53, 8, 661, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 20, 53, 8, 661, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 20, 53, 8, 661, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 20, 53, 8, 661, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15472f51-f64f-457d-92e2-197dea1b1f4b", new DateTime(2024, 5, 3, 20, 53, 8, 632, DateTimeKind.Local).AddTicks(2599), "AQAAAAEAACcQAAAAEHadcBY5CGsDLgtuM5S9pu+JOceDtxrkL9h3GlcDALTbXLiNO6MYaJva4JtDMl3Fww==", "f17c8636-6ecb-420c-839d-c6bb1ab607a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7148433c-692d-41ef-9e0d-4c7167f65391", new DateTime(2024, 5, 3, 20, 53, 8, 632, DateTimeKind.Local).AddTicks(2620), "AQAAAAEAACcQAAAAEIR/6bDX6SOIn1buPYOoa9sq2tVZJNJXbwacFgYP9NQekUgz8FqjaUubx+OTsiKALw==", "e34ce639-0a3f-465a-a8c6-1722fd359843" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "166285d1-d11f-423b-ab99-89edf4315eaa", new DateTime(2024, 5, 3, 20, 53, 8, 632, DateTimeKind.Local).AddTicks(2640), "AQAAAAEAACcQAAAAECoreU5akMj4OJJiyl0pIkGq/uQzFPbIhsc+TEKOfudVSI3okepb9NmBTWdvcJoXQg==", "d25c408c-adc2-451b-954b-8eb1a9cbcdf5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c675338a-2b00-4a68-b282-fdea324adc23", new DateTime(2024, 5, 3, 20, 53, 8, 632, DateTimeKind.Local).AddTicks(2646), "AQAAAAEAACcQAAAAEP59DXEYjnoI8TQsA3fZ810OLbj0uIzAjaATD0A+xrmsXgkuc587ZAAndEHobq6Fjg==", "aad4da10-7ce2-425f-bca8-52a23c2a1ebc" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 20, 53, 8, 662, DateTimeKind.Local).AddTicks(401));
        }
    }
}
