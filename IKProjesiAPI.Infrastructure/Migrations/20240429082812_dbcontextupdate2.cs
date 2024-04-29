using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class dbcontextupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "9c71a9d2-3a19-4f18-950f-7d07943a4294", new DateTime(2024, 4, 29, 11, 28, 11, 792, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5efad924-0000-451c-812a-030cbac5a0cb", new DateTime(2024, 4, 29, 11, 28, 11, 792, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5aa7f0cf-a3fa-4561-ad7b-3f5ac4b1dfa3", new DateTime(2024, 4, 29, 11, 28, 11, 792, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "16cb2448-995d-4357-9218-d6560f67dee0", new DateTime(2024, 4, 29, 11, 28, 11, 792, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 11, 28, 11, 792, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 11, 28, 11, 792, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 11, 28, 11, 792, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 11, 28, 11, 792, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4102dc1e-1a80-4e63-942f-18329fb51530", new DateTime(2024, 4, 29, 11, 28, 11, 755, DateTimeKind.Local).AddTicks(4712), "AQAAAAEAACcQAAAAEDLbP1gr3JvlmOkEpHs4xWuJa5XTKG/wh+Mibr9SHtltlVw/bh5KKJHXtfjUScEjcA==", "5b88616a-2ba4-4012-8164-99cc1d82739e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c41d27b1-bb05-44e4-9ffd-7ccf76085328", new DateTime(2024, 4, 29, 11, 28, 11, 755, DateTimeKind.Local).AddTicks(4755), "AQAAAAEAACcQAAAAEGa7nA3o1QnR+ehvvJ2h8EQEhv4fOiN4ALLHTjnWFrHVzFQd35AOFzUZPvM532zISQ==", "f1efdb03-efdd-480a-abc0-e833c6302ee1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73a57954-f97c-4b44-9c52-b99f17b761c8", new DateTime(2024, 4, 29, 11, 28, 11, 755, DateTimeKind.Local).AddTicks(4768), "AQAAAAEAACcQAAAAEJegmz6f0fZQg7sjt9XOnQhizTVD++GM7/+wfOhxWO9sy3PGPztrWiCthKYc7H77tQ==", "e920b02c-b095-45d0-953c-0598a8ff8db1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f86ac63f-601c-4b01-af3c-cdc7aada2006", new DateTime(2024, 4, 29, 11, 28, 11, 755, DateTimeKind.Local).AddTicks(4835), "AQAAAAEAACcQAAAAEBGz3d7eK4v6OSUNZM4K2hq/W6NZIqrVl412OPsHpRfHZJYT+NCrKH7xrTaa7ov+ow==", "67020f1b-3549-4580-ac48-efebb342be64" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 11, 28, 11, 792, DateTimeKind.Local).AddTicks(5173));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
