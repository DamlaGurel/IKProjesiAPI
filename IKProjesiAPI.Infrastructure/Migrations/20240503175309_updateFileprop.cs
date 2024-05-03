using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class updateFileprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "FileByteArray",
                table: "Expenses",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "da02a98c-c597-4566-bc1e-e0e5285ba149", new DateTime(2024, 5, 3, 20, 53, 8, 661, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "01b6e43d-7ca0-4ae4-af2c-3f05e549b199", new DateTime(2024, 5, 3, 20, 53, 8, 661, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "08f2da98-9b8b-43b6-8fb2-c9136a9309f1", new DateTime(2024, 5, 3, 20, 53, 8, 661, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "f0d7b3a2-b996-4bd9-a960-fda02b1935a8", new DateTime(2024, 5, 3, 20, 53, 8, 661, DateTimeKind.Local).AddTicks(4196) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileByteArray",
                table: "Expenses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "640d61e0-ace4-40b2-8346-0d32c94d936d", new DateTime(2024, 5, 2, 1, 35, 30, 286, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "523115a6-b8ac-4eac-8733-35b143de4832", new DateTime(2024, 5, 2, 1, 35, 30, 286, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "2a55223e-573f-4e28-b859-9dfc21515143", new DateTime(2024, 5, 2, 1, 35, 30, 286, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "345ead79-9adf-44f6-b831-e550ecfa19bd", new DateTime(2024, 5, 2, 1, 35, 30, 286, DateTimeKind.Local).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 1, 35, 30, 295, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 1, 35, 30, 295, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 1, 35, 30, 295, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 1, 35, 30, 295, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0389226-16cf-4d18-bb48-81c76c0b8aa8", new DateTime(2024, 5, 2, 1, 35, 30, 231, DateTimeKind.Local).AddTicks(7261), "AQAAAAEAACcQAAAAEJKDww6e2eQLhhLn9/lPnJlMUtv+By5tb9UWa4L+CyYq7x00kh3qATttLpAg/GuxtA==", "3a4efc7e-ba5b-4fca-8a48-7ad33d74b87f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d92e1bef-31e0-416b-a2d7-8d66c645b61b", new DateTime(2024, 5, 2, 1, 35, 30, 231, DateTimeKind.Local).AddTicks(7290), "AQAAAAEAACcQAAAAEADUgvdY5H4638dNkNWClAgN14RIKn6XZF7SRkGA3ccrxy7cYHbyvTf854HULD5oSQ==", "df8755d1-a27e-4563-8380-51b7e1a14c3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffddaab5-56d3-43e9-b505-b5a79774359c", new DateTime(2024, 5, 2, 1, 35, 30, 231, DateTimeKind.Local).AddTicks(7297), "AQAAAAEAACcQAAAAEArI4d1iWTeCMiTnBZ3lwPoT2/yX2Jbn6sPc8yIHQ8B3fOQK83IuqeLSbXoMf4RCig==", "0ed57079-7d18-441f-b86e-022976063e26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a02b552-59e6-4f21-b9a7-e1318425f1d3", new DateTime(2024, 5, 2, 1, 35, 30, 231, DateTimeKind.Local).AddTicks(7304), "AQAAAAEAACcQAAAAEOTMxpA0EyNLPXqI4+56Hr/RrXdv2bQosZhfjGxDqzdnAtLJ4uGDkQnT6Tq/A4Hh4w==", "5741ca7e-2ea3-4a52-b2bc-94e843b12441" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 1, 35, 30, 295, DateTimeKind.Local).AddTicks(9747));
        }
    }
}
