using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5e9a3ae2-6947-407c-a7c4-42eb944d2f94", new DateTime(2024, 4, 21, 22, 18, 43, 692, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "c9bc7d39-2a82-44d8-86ae-05641a2581b5", new DateTime(2024, 4, 21, 22, 18, 43, 692, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "b89a8390-6350-4773-960d-758579184162", new DateTime(2024, 4, 21, 22, 18, 43, 692, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "34276aad-cfbf-4ed2-8e6d-081e5bf87e87", new DateTime(2024, 4, 21, 22, 18, 43, 692, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 22, 18, 43, 692, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d8525dd-6b6f-4e0c-9da6-7c640cb2fd5d", new DateTime(2024, 4, 21, 22, 18, 43, 650, DateTimeKind.Local).AddTicks(6660), "AQAAAAIAAYagAAAAEDIAJiRDsMpZV4HA97s9R7K0ptWOLNeJSLZ7SC1tPig1gCHuE+uySiVLII073A4xFw==", "4e45a42e-ce12-4a20-a7ba-c18153d2c4a4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
