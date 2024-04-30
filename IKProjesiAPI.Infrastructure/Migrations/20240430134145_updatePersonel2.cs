using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class updatePersonel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "1e4c4c28-9887-495c-b08a-08412ba2e44a", new DateTime(2024, 4, 30, 16, 41, 45, 41, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "8e97665d-3446-49f6-8639-3f2b2e4d5a3d", new DateTime(2024, 4, 30, 16, 41, 45, 41, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "ab105042-9d9f-4a10-aa27-ecd96365e7a1", new DateTime(2024, 4, 30, 16, 41, 45, 41, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "68be9d5a-c654-4754-b4c5-f0415f149f29", new DateTime(2024, 4, 30, 16, 41, 45, 41, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 16, 41, 45, 41, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 16, 41, 45, 41, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 16, 41, 45, 41, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 16, 41, 45, 41, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5453149c-2eab-4d0b-9895-ae5a6120b56e", new DateTime(2024, 4, 30, 16, 41, 45, 3, DateTimeKind.Local).AddTicks(9652), "AQAAAAEAACcQAAAAEF7hB1pFemcuG/nexQI01MNBnRyQk8X6m9LznB1FM0SmEhW3w6/owBgoID8ljcFLFA==", "ebc47e9a-ee9f-4bdf-b341-939f6b21994b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca1b0fbf-c2b0-4ba3-8905-1ef4e4cb6e54", new DateTime(2024, 4, 30, 16, 41, 45, 3, DateTimeKind.Local).AddTicks(9684), "AQAAAAEAACcQAAAAECpdlO3ggD1jvzfKQXhJWDR1acDWwsxvVwEvq1YZbH4h1EhaKVAib7Bhjcks7+XX8g==", "6cf75df1-c5a3-4d5d-a52d-845bb72108bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aa8a451-2131-409a-b29d-2919d3a68284", new DateTime(2024, 4, 30, 16, 41, 45, 3, DateTimeKind.Local).AddTicks(9692), "AQAAAAEAACcQAAAAEB9LtV3lWx/UpDjbqq3i6GQyiZAg0PDzHi9L9acuZOJMQYPkhGZYQZfY1S/0daslIQ==", "b22fbb26-7fa8-4f60-a92e-4687d9be0547" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff864a48-b68b-485f-b760-2c715f4d277c", new DateTime(2024, 4, 30, 16, 41, 45, 3, DateTimeKind.Local).AddTicks(9698), "AQAAAAEAACcQAAAAEKGT9vQYFvUv75J47QQibJOuCHWswPvcTfYopNeSH0EILbaX3uwz1cpURSoH7IqOpQ==", "a0684e86-f4f8-44be-bfcf-662f4ff738ac" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 16, 41, 45, 41, DateTimeKind.Local).AddTicks(7717));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "46c397b8-d831-4ca0-a855-d72e8cff0c15", new DateTime(2024, 4, 30, 16, 38, 50, 613, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "0d13a0f2-a673-4923-8122-950d8f3f2a97", new DateTime(2024, 4, 30, 16, 38, 50, 613, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "cf6e491d-6838-4622-b38c-69dcf6d67443", new DateTime(2024, 4, 30, 16, 38, 50, 613, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "38143757-f13a-450d-8610-ac5f56e97f2f", new DateTime(2024, 4, 30, 16, 38, 50, 613, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 16, 38, 50, 614, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 16, 38, 50, 614, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 16, 38, 50, 614, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 16, 38, 50, 614, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4382cf66-5655-4386-aa3d-43712903c3e2", new DateTime(2024, 4, 30, 16, 38, 50, 580, DateTimeKind.Local).AddTicks(3693), "AQAAAAEAACcQAAAAEN7PFS+g3xdD5qR9XPL1MNS+r+mA8HN+b2D8su251Rg5kHILR5V46SZ5xp1TBvrt8w==", "37327077-4253-493a-af84-b5855d0aa1d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "619bf2ef-d0a0-4d3a-8667-6e14b2df4fd7", new DateTime(2024, 4, 30, 16, 38, 50, 580, DateTimeKind.Local).AddTicks(3715), "AQAAAAEAACcQAAAAEAkMyN2IfQSi16l1p6ZfwMGl5/Og78GZsUY/u5oFXI1NQi6GzceYwrSM5uZQ+md5Cw==", "d455c0f9-fbd4-497a-baed-5db6cfff442d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8389e22c-dd17-4b3f-a5c8-caee0eb474bd", new DateTime(2024, 4, 30, 16, 38, 50, 580, DateTimeKind.Local).AddTicks(3721), "AQAAAAEAACcQAAAAEOs5ssA+8kp8fTrw9wZWoJ9R8sFM9L//x/e1S7Trj9gL8y457+RS6kBnSALQdtgbUA==", "dc0a5a20-9bd6-405f-90ba-a662714d9580" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f11ce636-ccc6-4707-a4e0-6d42e8e8a06c", new DateTime(2024, 4, 30, 16, 38, 50, 580, DateTimeKind.Local).AddTicks(3738), "AQAAAAEAACcQAAAAEGPtCu+QEUC4BS1giwhT1DX96b6p2feSvPB66Yp4nQgUjpU12LcprOcEz69RKVnbPA==", "d4a9deb1-c374-4278-ab4f-7a12895aab48" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 16, 38, 50, 614, DateTimeKind.Local).AddTicks(3245));

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
    }
}
