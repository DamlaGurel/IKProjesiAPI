using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class propUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResponseTime",
                table: "Expenses",
                newName: "ResponseDate");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResponseDate",
                table: "Expenses",
                newName: "ResponseTime");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "a5572f26-b6ca-4fbf-b37f-f73fb512a4a8", new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "dbba606f-56b4-438e-8039-cd73da0835ad", new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "086092c3-80e8-4510-b559-70317cbeb71b", new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "c28ad066-bdba-4dba-9475-e51abcda1bcd", new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "948fa84e-4816-4705-8956-945f4ac0d0a5", new DateTime(2024, 5, 1, 15, 2, 3, 766, DateTimeKind.Local).AddTicks(7871), "AQAAAAEAACcQAAAAENGvNHB9+uT/fcUwoYSmD2ch58bqB1Madq85n8NKu9P9CMY/WjGqoRQhPzGb245g1A==", "009256f4-7b63-4f99-9e6b-79e2941845ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1887707b-cf6f-4423-a283-f3e14ddd7f38", new DateTime(2024, 5, 1, 15, 2, 3, 766, DateTimeKind.Local).AddTicks(7897), "AQAAAAEAACcQAAAAEJF32u7XpiTaag/DwROX/W+9dCx/CzGNX5BsjU2meqya2k2ikOAu6FYkilqmwkNlZQ==", "13622f0b-54a3-4721-88d2-3fe2a9c1a2ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d18f89b-0c89-4f9c-a466-2427d7c4ad2d", new DateTime(2024, 5, 1, 15, 2, 3, 766, DateTimeKind.Local).AddTicks(7906), "AQAAAAEAACcQAAAAEDRnqNwu45rPKsqY0d7MyxftXPvKxMtYMFjYGpEMcS0Ifwov7TlHvtNfYEjclMLuSQ==", "62c84b35-9e48-4290-a311-e3b5239d3f60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d831365a-de57-4d35-adae-985dfade0597", new DateTime(2024, 5, 1, 15, 2, 3, 766, DateTimeKind.Local).AddTicks(7915), "AQAAAAEAACcQAAAAEKZc1SETM4KD6m350/e4cuccxKLZKJpGSoos3F9I7EJVElxBBdj6ZGC4uePkoZmREA==", "b6478c05-2d9c-418e-aa9d-eb76027b372e" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 1, 15, 2, 3, 808, DateTimeKind.Local).AddTicks(503));
        }
    }
}
