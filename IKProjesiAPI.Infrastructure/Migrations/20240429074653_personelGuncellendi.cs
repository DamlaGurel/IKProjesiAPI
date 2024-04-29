using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class personelGuncellendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Personel_CompanyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Personel_CompanyId",
                table: "AspNetUsers",
                column: "Personel_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_Personel_CompanyId",
                table: "AspNetUsers",
                column: "Personel_CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_Personel_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Personel_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Personel_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5bbd6f93-838b-4774-b0e5-076dd8df0516", new DateTime(2024, 4, 28, 22, 39, 21, 877, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "c5f64199-f447-4754-9747-a0b22edba929", new DateTime(2024, 4, 28, 22, 39, 21, 877, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "bcf39828-f30e-401c-b38c-612667d2bf9e", new DateTime(2024, 4, 28, 22, 39, 21, 877, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "46e94903-acc0-4ed8-b7cb-7e89ddabfb24", new DateTime(2024, 4, 28, 22, 39, 21, 877, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 39, 21, 878, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 39, 21, 878, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 39, 21, 878, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 39, 21, 878, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa4dc11d-3b8d-45ce-9ad8-97c8423413a0", new DateTime(2024, 4, 28, 22, 39, 21, 850, DateTimeKind.Local).AddTicks(1347), "AQAAAAEAACcQAAAAEItlG5BvYnlsXOlRSf46/SmQStdcJxiT4bkRjPBxLTN2s49G7lzOCk07mGlqglE9Sw==", "260fb7d9-6d08-4f2f-a019-bb4bd4a0ea40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63395803-12ed-4406-9249-5122d600f346", new DateTime(2024, 4, 28, 22, 39, 21, 850, DateTimeKind.Local).AddTicks(1375), "AQAAAAEAACcQAAAAEMzqCdpW8FHOxTfd79/hCLTEVedud2tvC46f9tbLMgnM1xtUgfTQU9cpeEZ415LCkg==", "f406475b-3998-44d2-b767-82cd3281966b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d485223-3cd7-4f59-a1a8-5d81d4bf86a6", new DateTime(2024, 4, 28, 22, 39, 21, 850, DateTimeKind.Local).AddTicks(1381), "AQAAAAEAACcQAAAAENrHWttvvXza/+SnsbC8XLSZzU8ZB8BqG1Q5ceJV8OUqxTr6LLEhPJzQxASZ3bcuRg==", "f836f833-07d2-4cb0-9cfe-aa6a9b9879ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "296633d0-60dc-4184-ae80-9488d5b2cbad", new DateTime(2024, 4, 28, 22, 39, 21, 850, DateTimeKind.Local).AddTicks(1386), "AQAAAAEAACcQAAAAEJJnRFICm1NIL+S33zcTiT0jl9f4wgNZwllDbx23YA2IWdfbTnNfedyecMTe77K1hQ==", "abcf401f-7c5e-4042-8682-fb1636fdf215" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 39, 21, 878, DateTimeKind.Local).AddTicks(1371));
        }
    }
}
