using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class appUserProfilResmiKaldirildi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "9107682d-f2fa-41b8-b8e2-9d076ba30534", new DateTime(2024, 4, 19, 18, 29, 42, 823, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "7f830427-141e-4231-b37e-d3c2eca86edc", new DateTime(2024, 4, 19, 18, 29, 42, 823, DateTimeKind.Local).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "34943df7-7a5f-45fd-b695-c68885a93f9d", new DateTime(2024, 4, 19, 18, 29, 42, 823, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "b06b2230-f247-4905-877f-23e65d6f379a", new DateTime(2024, 4, 19, 18, 29, 42, 823, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 18, 29, 42, 823, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18444c43-2045-46a4-a319-9983f92e0595", new DateTime(2024, 4, 19, 18, 29, 42, 814, DateTimeKind.Local).AddTicks(7638), "AQAAAAEAACcQAAAAEPIEbyPhrU4ADg1+nKnxpIYwdpUQbMH5FHtDd2m/cqChXDcyGpsBFhdM5pqh/Bu6+w==", "0aa2315b-88db-4653-84c5-818fd7b24fa5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
