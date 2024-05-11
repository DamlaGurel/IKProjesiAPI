using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class personalEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PersonalEmail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "cbba030a-c2b3-4cf7-bb64-6725cc8e7e56", new DateTime(2024, 5, 11, 15, 48, 42, 352, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "d25fa8aa-a48e-4c3a-8af9-67d488dc5e51", new DateTime(2024, 5, 11, 15, 48, 42, 352, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "de563d00-42cb-4365-99b0-d0c2f3dff59a", new DateTime(2024, 5, 11, 15, 48, 42, 352, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "792dd292-3137-469e-8a24-3b8712afade5", new DateTime(2024, 5, 11, 15, 48, 42, 352, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 15, 48, 42, 352, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 15, 48, 42, 352, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 15, 48, 42, 352, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 15, 48, 42, 352, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "653beaf9-e611-4c9b-9f7a-b8f725b5ea0a", new DateTime(2024, 5, 11, 15, 48, 42, 321, DateTimeKind.Local).AddTicks(9121), "AQAAAAEAACcQAAAAEMpM6xI4eW/fKWfF6yZV42PsaIn2kBo4ZjDcTh7xuEKefBd1GGHjo/8EXrAP/ZZKpw==", "d5b33ae9-503d-4684-ba69-9b968d2ca13e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8517739c-fcbc-4322-9b70-a9df510a52af", new DateTime(2024, 5, 11, 15, 48, 42, 321, DateTimeKind.Local).AddTicks(9140), "AQAAAAEAACcQAAAAEGkXpVm+6zuZDrt2h+lVCU8yKTBaSbbHc+oggdsEcWYtq1wZ6UvWUPlFAiRZfxKxUQ==", "c3d87b16-6328-41ae-8507-3e6e55893b73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1985ad9a-6687-4dce-aafe-f8c30e62995a", new DateTime(2024, 5, 11, 15, 48, 42, 321, DateTimeKind.Local).AddTicks(9146), "AQAAAAEAACcQAAAAEBTBtX8Yd8lffLIGpYbnbIeKK0a4Dt6PHxtgLLSSQkHYBIjANX3wU7639RZpTsuuKA==", "d2caa4ef-1d40-4f19-84d9-eb9594c1f913" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b16d3d5-fdf0-467a-8128-de06f8ad4280", new DateTime(2024, 5, 11, 15, 48, 42, 321, DateTimeKind.Local).AddTicks(9151), "AQAAAAEAACcQAAAAEPfthUp115BIdhOXDMUVta90whKFSOvyyc3sfkiG4+JtOGEUz2f+znEtwCrtonZwrA==", "cdc2292a-f54b-4d4b-9861-755224861500" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 15, 48, 42, 352, DateTimeKind.Local).AddTicks(8327));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalEmail",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "e9c5dd1a-b8aa-43b2-a599-a617f6ce4c79", new DateTime(2024, 5, 10, 14, 43, 58, 894, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "83f5594b-c853-47f8-a839-72364f329afa", new DateTime(2024, 5, 10, 14, 43, 58, 894, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5b8c8b6e-90c9-4d87-acfa-ef7d524cf451", new DateTime(2024, 5, 10, 14, 43, 58, 894, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5498e6cf-52a8-4913-b00f-aa86d0a39411", new DateTime(2024, 5, 10, 14, 43, 58, 894, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 14, 43, 58, 895, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 14, 43, 58, 895, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 14, 43, 58, 895, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 14, 43, 58, 895, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b6c4c4c-4116-4848-b10b-7df9c565fd95", new DateTime(2024, 5, 10, 14, 43, 58, 865, DateTimeKind.Local).AddTicks(309), "AQAAAAEAACcQAAAAELA7wORbIiws01VykkESw1xSP1bEi2pcCFxZmN8MomK/pMsK8iWjzin2LTFj7TaifQ==", "8d781dab-3327-47b4-950b-f5dbafc87ee6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aba0440-78d2-429c-b306-0fddbc732cb7", new DateTime(2024, 5, 10, 14, 43, 58, 865, DateTimeKind.Local).AddTicks(327), "AQAAAAEAACcQAAAAELg7rjiclElhpQ9CDANg4zfcIDAGD4ay6GXGbeDVUS7y1+1RlYg0jWJUNdGUq7t4BA==", "69c584d8-e8f4-4b7b-a63e-cc0ef2e670d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20fdf1d9-e18c-439f-9af0-6f94411a0407", new DateTime(2024, 5, 10, 14, 43, 58, 865, DateTimeKind.Local).AddTicks(333), "AQAAAAEAACcQAAAAEKyGYFtB3IhJ8NTwoT2ZeU71wjW5EZwSmYvI/2XKtT5W0GlqBikCGH5dG/fG/xejWg==", "124020fc-a2ca-4600-937a-b1773ce87e0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b335308b-c83e-4874-8135-d7edc999b92c", new DateTime(2024, 5, 10, 14, 43, 58, 865, DateTimeKind.Local).AddTicks(338), "AQAAAAEAACcQAAAAEKHs63QsDgCwbKX4IkDJyCPJ3TQLzv/q2ZkAO4FDNsQMTjCOUbsyaa6IlmbjgqFisg==", "db668888-69e8-40ed-a08e-06ae2daab371" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 14, 43, 58, 895, DateTimeKind.Local).AddTicks(3072));
        }
    }
}
