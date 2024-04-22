using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class tabloayirmadeneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "AppUserFirstName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedName" },
                values: new object[] { "83c72b42-2c49-472f-b07a-02a1723f5d8c", new DateTime(2024, 4, 20, 12, 48, 21, 255, DateTimeKind.Local).AddTicks(9320), "SUPERADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedName" },
                values: new object[] { "11f73161-2b92-4d42-9089-7dc9f754d037", new DateTime(2024, 4, 20, 12, 48, 21, 255, DateTimeKind.Local).AddTicks(9340), "SITEMANAGER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5ce0e6c7-9762-4697-b42b-10055ffd4b61", new DateTime(2024, 4, 20, 12, 48, 21, 255, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "463fc91e-8126-440f-9b71-c356580ebd1b", new DateTime(2024, 4, 20, 12, 48, 21, 255, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 12, 48, 21, 255, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eb21920-7af0-42c2-9357-d5aab0ee4e83", new DateTime(2024, 4, 20, 12, 48, 21, 212, DateTimeKind.Local).AddTicks(8220), "AQAAAAIAAYagAAAAEPRln7JG00hlZzdeaCfSFKLEmgI/kzhw6BMlqlwkbRyh6QNk55WsO4h3+/2O47HwYw==", "3e3677a5-ece8-4524-898c-be1c2502f8e3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppUserFirstName",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedName" },
                values: new object[] { "2645ad0b-60f8-4527-9019-4aa80754b6fd", new DateTime(2024, 4, 19, 14, 29, 12, 145, DateTimeKind.Local).AddTicks(5387), "SUPERADMİN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedName" },
                values: new object[] { "3752c7c3-1894-4e5d-8edd-3b4a540186fa", new DateTime(2024, 4, 19, 14, 29, 12, 145, DateTimeKind.Local).AddTicks(5398), "SİTEMANAGER" });

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
