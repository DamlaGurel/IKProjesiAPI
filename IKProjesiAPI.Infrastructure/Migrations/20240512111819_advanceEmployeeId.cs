using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class advanceEmployeeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancePayments_AspNetUsers_EmployeeId",
                table: "AdvancePayments");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "AdvancePayments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "3869a0e0-5183-48cd-9f2b-dd7fed4394de", new DateTime(2024, 5, 12, 14, 18, 18, 67, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "02c7b26b-f54b-40e6-a026-bbd623264030", new DateTime(2024, 5, 12, 14, 18, 18, 67, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "9ba019ee-69c1-45f0-b5c0-0407b9136d6a", new DateTime(2024, 5, 12, 14, 18, 18, 67, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "3006dbd9-65d6-46e6-96c3-0d75c5f928da", new DateTime(2024, 5, 12, 14, 18, 18, 67, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 18, 18, 67, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 18, 18, 67, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 18, 18, 67, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 18, 18, 67, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da7a87e3-7781-4e58-b8b4-ab053ff21aba", new DateTime(2024, 5, 12, 14, 18, 18, 34, DateTimeKind.Local).AddTicks(4901), "AQAAAAEAACcQAAAAEAiY/gc6HZU+rfu/9cid1nt1o3exPS/TKYnicL2KAfcLG8rikL8IYTadkcyIbnVPUw==", "eae0fe69-891d-4dd1-bc04-60f5591ce78d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aab5530-ed86-4ab7-adc2-947b9e6a0839", new DateTime(2024, 5, 12, 14, 18, 18, 34, DateTimeKind.Local).AddTicks(4920), "AQAAAAEAACcQAAAAENECw1CsFyOuUMoeT2wqcmfbRl190qFpVDZE6FX+6gsbTz4compVJGjznkicJ3xVkw==", "d064dcf7-dbae-43fc-8c48-50f1de7e1c1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d5d374f-bb4f-4914-8657-040536485da2", new DateTime(2024, 5, 12, 14, 18, 18, 34, DateTimeKind.Local).AddTicks(4937), "AQAAAAEAACcQAAAAEAQAeQstOC8UPDlVe/fTLk8Kz8iuj2Jd0mLyPZs6uU5593c4Q+1l+yTU6JdGbBxZEQ==", "48ca29c3-db27-4977-abcd-21c71c88bb3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35399aff-e257-40ac-9130-acf9489e524c", new DateTime(2024, 5, 12, 14, 18, 18, 34, DateTimeKind.Local).AddTicks(4943), "AQAAAAEAACcQAAAAEN0ZA1gt1G2RYeOtwujuupPV2fmD4iX3OcMCXwT32nn2yYSmbW2RWJNGpH2P6KS3Ew==", "d0c94b70-5234-48e0-bdb9-473e97439b6d" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 18, 18, 68, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancePayments_AspNetUsers_EmployeeId",
                table: "AdvancePayments",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancePayments_AspNetUsers_EmployeeId",
                table: "AdvancePayments");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "AdvancePayments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancePayments_AspNetUsers_EmployeeId",
                table: "AdvancePayments",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
