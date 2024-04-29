using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class dbcontextupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "6dc522a8-51d0-447c-92c0-b2250c0cc1eb", new DateTime(2024, 4, 29, 11, 18, 27, 316, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "d19c5a5c-bfc6-44b4-ba87-7e90f2c02348", new DateTime(2024, 4, 29, 11, 18, 27, 316, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "f956d059-701b-469d-8d51-22c1e270e114", new DateTime(2024, 4, 29, 11, 18, 27, 316, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5bb9d9b4-bbb0-4ee0-b2b8-a1239f221b10", new DateTime(2024, 4, 29, 11, 18, 27, 316, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 11, 18, 27, 316, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 11, 18, 27, 316, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 11, 18, 27, 316, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 11, 18, 27, 316, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd3e1683-c5f4-4681-86c6-f690f4732ab0", new DateTime(2024, 4, 29, 11, 18, 27, 284, DateTimeKind.Local).AddTicks(8752), "AQAAAAEAACcQAAAAEJAgBfD/dzKVwiwlGyEylH4FBdj5ceqnhcxiZcuFnvgzW8xRYTArU9vXL70I8+k6bg==", "ffded74f-3cfa-452b-a893-0d5c73469294" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4442496-a460-4690-804e-e6c15c44f926", new DateTime(2024, 4, 29, 11, 18, 27, 284, DateTimeKind.Local).AddTicks(8781), "AQAAAAEAACcQAAAAEMoJzq1EVCGs0WlNAmFhXu7nP3Lh8PEDqdhQJARrZb0H54+pAkda+l3u8t44MmBtLA==", "36f82636-bb35-44ef-b962-e55d1e1cc543" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4be9e0b0-1f33-411d-90b4-0fd4f0dbc1b8", new DateTime(2024, 4, 29, 11, 18, 27, 284, DateTimeKind.Local).AddTicks(8792), "AQAAAAEAACcQAAAAEBpTcelQItgpGi15qv6BWZ7vrFLKDpJscpDnWKyeRqKdtjm+7EnD8GgTQe7yQB294g==", "d47d2e33-9701-4a2b-a6a2-b37459f9894a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34950d45-77d2-4b1f-93ef-c251d0faa382", new DateTime(2024, 4, 29, 11, 18, 27, 284, DateTimeKind.Local).AddTicks(8804), "AQAAAAEAACcQAAAAEIKQZZd0Sd/sRcpLjsRuQ23Vk9AfR+ohMvvmclzdXeWURFbGpj/g8yIKBwsTqhLpcw==", "f9beb3d2-b3f3-4ddc-8771-d4507e006e0d" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 11, 18, 27, 317, DateTimeKind.Local).AddTicks(571));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "86bdf05c-44a6-4de4-9489-5a06785e3a34", new DateTime(2024, 4, 29, 10, 46, 52, 460, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "a0f5f691-1c33-4318-b5f3-7509b4513196", new DateTime(2024, 4, 29, 10, 46, 52, 460, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "e505a9cc-38c6-404f-a5b9-55f5e659b105", new DateTime(2024, 4, 29, 10, 46, 52, 460, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "3348632f-f837-4a88-b230-bdfe541a2a11", new DateTime(2024, 4, 29, 10, 46, 52, 460, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 10, 46, 52, 460, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 10, 46, 52, 460, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 10, 46, 52, 460, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 10, 46, 52, 460, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e71e611-df24-42c1-9c08-0a67d65a88c9", new DateTime(2024, 4, 29, 10, 46, 52, 427, DateTimeKind.Local).AddTicks(4383), "AQAAAAEAACcQAAAAEAAnYD+3p3eX0h543b3LX45yzVjNSHxNXD6NiwYnCRAUblYwiExeRXgsZhdWCxLH8g==", "341ecd1d-d0db-4237-92e0-3f7cafdf9506" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b935627-2a4d-4457-be04-794dd7807ca8", new DateTime(2024, 4, 29, 10, 46, 52, 427, DateTimeKind.Local).AddTicks(4420), "AQAAAAEAACcQAAAAEHP/AawOUEfR2zQYgNQX08+z1pNYOKANiSr4c19OYWf6h4YFrIA2A/bYdjbvoFfixA==", "d9b2b696-832f-4f77-817c-938268c7904c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ba1ffbf-a1fc-456e-acf5-f91b2fcd58cc", new DateTime(2024, 4, 29, 10, 46, 52, 427, DateTimeKind.Local).AddTicks(4428), "AQAAAAEAACcQAAAAEE+Z+NX0zrwpYmQ6ARlDCsiEjZdUgPVtoGMZrYFGvYeeL36MTIMuuaBmpejwaoNBNA==", "df800d61-fd26-49a5-b222-051b40db514a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa38cf27-eb4c-4b77-81b9-883cea3ba96b", new DateTime(2024, 4, 29, 10, 46, 52, 427, DateTimeKind.Local).AddTicks(4436), "AQAAAAEAACcQAAAAEDstl3EGOggGMXrGUIZG2DKIn5ypMZsnPiv/y0FyB4i5WfMxJyKliy6bTAIbqiR3TQ==", "7aade820-b5f9-461a-a6a8-669ef2482c89" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 10, 46, 52, 460, DateTimeKind.Local).AddTicks(6040));
        }
    }
}
