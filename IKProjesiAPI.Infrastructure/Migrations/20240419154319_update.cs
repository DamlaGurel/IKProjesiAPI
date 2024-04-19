using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5f4a7ef6-0ce1-4906-93d1-734659f324c9", new DateTime(2024, 4, 19, 18, 43, 19, 267, DateTimeKind.Local).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "6d57d311-9a80-4eeb-af94-fe0f81dcc816", new DateTime(2024, 4, 19, 18, 43, 19, 267, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "46754cc6-789b-4a84-b2e3-aa2315ea18fe", new DateTime(2024, 4, 19, 18, 43, 19, 267, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "11fec0ee-a206-4b35-99a8-d46dac113d9d", new DateTime(2024, 4, 19, 18, 43, 19, 267, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 18, 43, 19, 267, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2294084b-5514-4e97-be27-9c0f9cf9d813", new DateTime(2024, 4, 19, 18, 43, 19, 258, DateTimeKind.Local).AddTicks(9295), "AQAAAAEAACcQAAAAENSLVuglVlO+S1g8TXTX1yh2N7kyg3JBRwECg0b+fayYW2WJr/ZwmcIY1tq8o6HDnw==", "9b9d0727-e926-4c53-97c2-b7642808a2b6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
