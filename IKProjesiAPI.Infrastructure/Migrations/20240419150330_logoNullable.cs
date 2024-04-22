using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class logoNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "ce0dcbaa-ab8f-4073-a088-1e76262d041a", new DateTime(2024, 4, 19, 18, 3, 29, 333, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "1c13f3f8-e6fc-4dd7-b730-a18a2e2916be", new DateTime(2024, 4, 19, 18, 3, 29, 333, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "7edeeb14-55b3-41cd-87c5-768e849667d4", new DateTime(2024, 4, 19, 18, 3, 29, 333, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "fb65e3a4-bff2-4755-8c1b-340d1d34d6b7", new DateTime(2024, 4, 19, 18, 3, 29, 333, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 18, 3, 29, 333, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0c81f5a-9d47-4b17-aea1-87a3c214a092", new DateTime(2024, 4, 19, 18, 3, 29, 324, DateTimeKind.Local).AddTicks(6123), "AQAAAAEAACcQAAAAEOv3rWO6M0ubr0cP8SPL5UskND1RWUv1RI+ocwi2Pgue9Cdcmd7QzQAPfJZNC9ufeg==", "93701452-df53-4896-9cb5-a27da9949b3f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "2645ad0b-60f8-4527-9019-4aa80754b6fd", new DateTime(2024, 4, 19, 14, 29, 12, 145, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "3752c7c3-1894-4e5d-8edd-3b4a540186fa", new DateTime(2024, 4, 19, 14, 29, 12, 145, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "e10c804f-01cc-470b-89a5-9a1e6e8c1661", new DateTime(2024, 4, 19, 14, 29, 12, 145, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "219e8bd6-4ba6-4a70-9fbb-863f615e70e6", new DateTime(2024, 4, 19, 14, 29, 12, 145, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 14, 29, 12, 145, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d1a8748-fc79-4ba8-839a-650501d976b9", new DateTime(2024, 4, 19, 14, 29, 12, 138, DateTimeKind.Local).AddTicks(6757), "AQAAAAEAACcQAAAAENpoc4Yo8WolKjga/IXP5VIC/6Kz1R4hcn78ADzY/HNCxNs+tuLQEmggZ2/E3Uwn9A==", "382894f3-b19c-4858-8e84-318bcdba6336" });
        }
    }
}
