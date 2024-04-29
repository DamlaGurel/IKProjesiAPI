using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class dbupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "76eded09-75dc-4ed2-867b-14e8c6db9ccd", new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "eae178b4-e662-45d8-a65f-f74507993394", new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "c557a0f0-6a61-4163-9fc4-0037ac391551", new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "27f4890c-b33b-4239-bae2-af65353023f5", new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96f04e99-4d49-4fbc-ad93-2b7db175bf85", new DateTime(2024, 4, 29, 15, 13, 31, 919, DateTimeKind.Local).AddTicks(9165), "AQAAAAEAACcQAAAAELykxw7v/p8v98QWPJjrwiLfj287IRaNVCWMEAS9wCwso2asHnvV7LiVYf1KDxNeWA==", "e1eb51e0-9d07-4421-94d1-2bf22bc69639" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2785776-3a83-4a54-9fad-d19c92da72c9", new DateTime(2024, 4, 29, 15, 13, 31, 919, DateTimeKind.Local).AddTicks(9185), "AQAAAAEAACcQAAAAEFGrMmJtqGctYfNnajIKQWKlAqe/mzFOyr4nU3KoaehlZPpfJzBCLuGp/Tcwt/mTGw==", "d5356b2e-f16b-4605-9ed5-6cc648997bb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd9aedf6-a379-4245-82d9-aa51b08b4f1f", new DateTime(2024, 4, 29, 15, 13, 31, 919, DateTimeKind.Local).AddTicks(9207), "AQAAAAEAACcQAAAAEOkzc8b6Lmzm7PHU3PiBJ4AnaVmtbhVK17i3TvPxw+3jFJPGBwUr/vGwZ5HlbcOcIQ==", "d7c29ac5-d38b-4981-95a1-92fe51cbbe03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f552381-db57-45e2-8f26-dd7330613257", new DateTime(2024, 4, 29, 15, 13, 31, 919, DateTimeKind.Local).AddTicks(9215), "AQAAAAEAACcQAAAAEKXbVb2YJ51HERj7BzPqXNZtMizB5vb8s1OvehBzJpFNbZUpxrMC52QfpTx9jo0P8g==", "c7bfc5f4-d033-4613-bb6f-0f020d3aabc8" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(7632));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
