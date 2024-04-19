using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class logoKaldirildi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoPath",
                table: "Company");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "612aaa71-3835-4c81-ad43-ff3baec143f0", new DateTime(2024, 4, 19, 18, 26, 31, 75, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "7f3b7170-b31e-42f7-81aa-5c0dfe03590b", new DateTime(2024, 4, 19, 18, 26, 31, 75, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "44deb4ce-4581-414b-b71f-6e924fcc3792", new DateTime(2024, 4, 19, 18, 26, 31, 75, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "24570b36-1a7e-4d9e-943a-8c8bb579e84b", new DateTime(2024, 4, 19, 18, 26, 31, 75, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 18, 26, 31, 75, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "051da389-9b84-4663-8b7d-731a146f7971", new DateTime(2024, 4, 19, 18, 26, 31, 67, DateTimeKind.Local).AddTicks(1574), "AQAAAAEAACcQAAAAEGL1aiQ/7vHp2LOua9iIv6xn9BLsZr4OTfvfbdrnh9yBu9OOWEP2qR4LdcVxdgiF1w==", "654d68b5-0754-4bf2-b128-31b988c76cd1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LogoPath",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "943ec845-698f-4c9d-bc46-736081d2bd9e", new DateTime(2024, 4, 19, 18, 19, 59, 441, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "16cf9709-6e1c-413b-b6f8-eb9c8f24e758", new DateTime(2024, 4, 19, 18, 19, 59, 441, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "d4ec68fe-9146-46f8-b3a1-2015851f3c0a", new DateTime(2024, 4, 19, 18, 19, 59, 441, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "e02f9067-d246-42cb-b23d-0b17b9b4e24e", new DateTime(2024, 4, 19, 18, 19, 59, 441, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 18, 19, 59, 441, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f923c78a-edaf-42b1-88c5-0ef684a3d414", new DateTime(2024, 4, 19, 18, 19, 59, 433, DateTimeKind.Local).AddTicks(2797), "AQAAAAEAACcQAAAAEGHvxuKmBrJIE08AnkE2QAIGjXF46g4Bodm4tsLrUVI+8esgedjJAZNL5C3NRFD2+g==", "f58cf55b-5c40-4b72-a8d7-cc0136230fa6" });
        }
    }
}
