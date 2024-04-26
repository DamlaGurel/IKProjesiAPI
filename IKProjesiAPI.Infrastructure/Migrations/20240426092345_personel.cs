using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class personel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "d8474dbb-8b3a-4134-91ac-1a1afb124389", new DateTime(2024, 4, 26, 12, 23, 44, 529, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "26a174bc-5cc9-4a73-95fc-cb39a48beabb", new DateTime(2024, 4, 26, 12, 23, 44, 529, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "780d1c05-9176-4b3d-a479-f2cd8f9b9653", new DateTime(2024, 4, 26, 12, 23, 44, 529, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "98f8d84b-a048-4c97-a734-8eae2755969e", new DateTime(2024, 4, 26, 12, 23, 44, 529, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 12, 23, 44, 529, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 12, 23, 44, 529, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 12, 23, 44, 529, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 12, 23, 44, 529, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83b861d8-d1d9-42cf-8662-62d9d2f0a520", new DateTime(2024, 4, 26, 12, 23, 44, 493, DateTimeKind.Local).AddTicks(2341), "AQAAAAEAACcQAAAAELc7AdJUo8fEvJHZHt0gqubGFnyza8+3X4NgtXvOqeDvLKXCZVFFL5l0Iu7lXfnnvw==", "b9e23e4d-c36a-4ace-9f93-a21311a86a5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecb9b94f-30f9-4431-ad17-a719d811c570", new DateTime(2024, 4, 26, 12, 23, 44, 493, DateTimeKind.Local).AddTicks(2361), "AQAAAAEAACcQAAAAEK8ybg6+uzH0vGUiALMVYWF+1TVKneyG+gcyjfLHxEuWe5vVVUBXcysLUaACb9o+XA==", "1d944daf-3615-4072-aaf9-3ca827cf8f09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5d56046-56b8-4608-a860-5035c6aba569", new DateTime(2024, 4, 26, 12, 23, 44, 493, DateTimeKind.Local).AddTicks(2367), "AQAAAAEAACcQAAAAEIX78hnCyvcBeAp5HfZkRHKmZBEwTHwJNXh/BL7vx2JgPudRxohEXriF5Syic1BKsQ==", "bd7623b0-c0b5-4d0a-986e-ab5520a4b154" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3665ca4e-aa7f-4e7a-b3de-3764912b5160", new DateTime(2024, 4, 26, 12, 23, 44, 493, DateTimeKind.Local).AddTicks(2385), "AQAAAAEAACcQAAAAEIqoybjuwX+2CgNRgf73WPS9fqN7Yzd2knD9infk21zumrJvQGa/ODH7nWB3zzSdhA==", "30193650-632e-4737-b7b0-88bb17231dc9" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 12, 23, 44, 529, DateTimeKind.Local).AddTicks(1658));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "10298f25-bd2c-4771-80a9-4e7677760d82", new DateTime(2024, 4, 26, 12, 19, 34, 592, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "3b29eadb-a528-4123-9e2c-3e10b71211a2", new DateTime(2024, 4, 26, 12, 19, 34, 592, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "a1910085-950d-4f43-aff3-a23b4c5e373a", new DateTime(2024, 4, 26, 12, 19, 34, 592, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "f03fdb3f-07d7-42ab-9be0-4d9a38b03666", new DateTime(2024, 4, 26, 12, 19, 34, 592, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 12, 19, 34, 592, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 12, 19, 34, 592, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 12, 19, 34, 592, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 12, 19, 34, 592, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13f84054-fdf9-40c5-a50a-aabfb3ae9597", new DateTime(2024, 4, 26, 12, 19, 34, 557, DateTimeKind.Local).AddTicks(6415), "AQAAAAEAACcQAAAAELaq2qc6/TMFqL2mLuyZW9jcbFMwv4PEdeLg0jbv9qhx73BaZ1ebocugwY0mdtr3HQ==", "7566237f-8fe3-48ad-9828-2f010e591011" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86920c5d-4b16-4ac2-82ba-c8aa0aa00165", new DateTime(2024, 4, 26, 12, 19, 34, 557, DateTimeKind.Local).AddTicks(6450), "AQAAAAEAACcQAAAAEFxZeGG18TnBjsWtkQXz9XTWQjjIGkQu7XM3Sl8VE8+IDO3F/ZPs8E/AaHFaiCxS2Q==", "b3bf3dfc-5efd-429a-b4a9-0993274f689c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5af398de-d354-4638-b0e4-e234302dab1c", new DateTime(2024, 4, 26, 12, 19, 34, 557, DateTimeKind.Local).AddTicks(6456), "AQAAAAEAACcQAAAAEC+qNf8aB6nsfbTU1+O96k9qFw8O7OpDNq33LDQwh/ur70JfPNCVdza0M3TnGdNE3A==", "3246f857-cce3-49b3-b0c9-4dc0658f8806" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f668555c-c136-41de-a189-4fe5fb78c432", new DateTime(2024, 4, 26, 12, 19, 34, 557, DateTimeKind.Local).AddTicks(6462), "AQAAAAEAACcQAAAAEBMRdtxGi7NeLJEQox33Y7dhfhR0Z58Nb3v403hQEvMGLl+huilxG6JGiXeFiM8nzw==", "f1eeb075-425d-4dbd-8130-9531cdb8969a" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 12, 19, 34, 592, DateTimeKind.Local).AddTicks(5954));
        }
    }
}
