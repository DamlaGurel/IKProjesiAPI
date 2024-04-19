using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class companyManagerVeCompanyNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
