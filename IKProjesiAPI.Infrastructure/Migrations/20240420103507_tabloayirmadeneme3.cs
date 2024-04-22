using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class tabloayirmadeneme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "1ee74e73-66d7-4c20-9fa3-9013c73fbc80", new DateTime(2024, 4, 20, 13, 35, 6, 962, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "383f0779-be50-44f5-a2e6-5be597a657a3", new DateTime(2024, 4, 20, 13, 35, 6, 962, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "92b39863-22c1-404a-92b9-86dd6d404cb5", new DateTime(2024, 4, 20, 13, 35, 6, 962, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "4cd69021-5771-4ff8-8381-85b583ee4976", new DateTime(2024, 4, 20, 13, 35, 6, 962, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 35, 6, 962, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4e3502c-1930-48b2-be6f-2d18ff6997b3", new DateTime(2024, 4, 20, 13, 35, 6, 919, DateTimeKind.Local).AddTicks(8840), "AQAAAAIAAYagAAAAEHT7zluZwM/HqTmIxXp2HCUKYQ4JDcNjzlBTi/c7imlfFIXBvEVGdvKPyUswQywQrQ==", "227553f6-33b3-41d7-8a3e-4a883aad0195" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "0a1fe396-0fc4-41a0-96df-dced0ae0ce16", new DateTime(2024, 4, 20, 13, 31, 25, 857, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "569845ad-80d9-41d8-9def-415576aa703b", new DateTime(2024, 4, 20, 13, 31, 25, 857, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "669d2603-0763-4cb6-9d87-c1dd7f685958", new DateTime(2024, 4, 20, 13, 31, 25, 857, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "ed3e58fe-ff15-4efa-a996-8d43a1dc4465", new DateTime(2024, 4, 20, 13, 31, 25, 857, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 31, 25, 857, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b12198e4-a595-446b-8fde-f022d4a23ff2", new DateTime(2024, 4, 20, 13, 31, 25, 814, DateTimeKind.Local).AddTicks(8530), "AQAAAAIAAYagAAAAEM2iHhNAHBexQ3/Zigqq7VYZR45/DC6iLpx1dyvNF7FArIKeP/plu9hJto5OMXuGCg==", "23dd6b84-0e15-46f9-87ae-e56c73682a5d" });
        }
    }
}
