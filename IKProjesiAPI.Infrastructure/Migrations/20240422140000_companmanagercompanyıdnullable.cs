using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class companmanagercompanyıdnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "b765be68-223b-443b-ac9b-61080b8808a9", new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "49d90cc2-eb62-4490-9bc2-6e684856dd70", new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "07c92b3b-eea7-4f1a-91e4-02abbaacb724", new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5e9967b3-d790-44c8-abf0-19819668ded2", new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "992af79d-5b17-44e2-a385-71c211922fa2", new DateTime(2024, 4, 22, 16, 59, 59, 599, DateTimeKind.Local).AddTicks(8470), "AQAAAAIAAYagAAAAEPWhTcWVnmFY3jKC5vzC/ZSaVo/0PANuuLDGw+Zp/R3DZvXbLp5j8fiuAKcZpMrvUA==", "830a2ecb-8ab9-41f4-9ca8-ba18f6ea947d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "661b4910-9afe-4772-8c4e-003e53322f0d", new DateTime(2024, 4, 22, 16, 59, 59, 599, DateTimeKind.Local).AddTicks(8530), "AQAAAAIAAYagAAAAEJJGdGWws9xP2zmgMHEcue+ltOry4VhfTyROCazLbMyVGwkhub8dRNceTibjSXlBwg==", "05d0353f-c944-4207-a31d-3bfe12e614d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "564248a2-4b8e-455e-a68e-195c9a688914", new DateTime(2024, 4, 22, 16, 59, 59, 599, DateTimeKind.Local).AddTicks(8540), "AQAAAAIAAYagAAAAEL88Cx4cjtk2Orw3+es2Ccw+xMKbA65IjkvJJlyrkwi+wsGISk8aqfv1qqkeRuE/iQ==", "2e315005-799e-4acb-908e-2390f2a69c7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d833d11-72b4-44e6-af3b-9293326a7abc", new DateTime(2024, 4, 22, 16, 59, 59, 599, DateTimeKind.Local).AddTicks(8550), "AQAAAAIAAYagAAAAEKHONtsDBsOTK+B/QHac/Vx7g8K6djSk3kTduEZfiM6cfKtZBB0YQgn1hp1mCq3YBg==", "a3b2b7bd-7660-4118-85de-456bb35b4283" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "843d8772-8bc9-432b-ba98-f644a8753f5f", new DateTime(2024, 4, 22, 16, 57, 58, 806, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "6993aab3-e972-4f00-836d-cd5569ddd4e2", new DateTime(2024, 4, 22, 16, 57, 58, 806, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "953255ce-87e7-4961-a36b-d27592bef97d", new DateTime(2024, 4, 22, 16, 57, 58, 806, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "90d9b046-2793-47ff-a473-94499bc3f947", new DateTime(2024, 4, 22, 16, 57, 58, 806, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 57, 58, 806, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 57, 58, 806, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 57, 58, 806, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 57, 58, 806, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "572518dd-3829-4d82-b8de-9c3ef0714ec2", new DateTime(2024, 4, 22, 16, 57, 58, 637, DateTimeKind.Local).AddTicks(8310), "AQAAAAIAAYagAAAAEAp3uYvB20GTyKVcpJMiWW06jihr68aX5rj7idY1rjzrsKZDFE7+CU3Pon4UKewczg==", "700ba704-a181-4c2f-94e6-50e8a766b57a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7ff1798-db39-4ad2-b2e4-0274abbef08a", new DateTime(2024, 4, 22, 16, 57, 58, 637, DateTimeKind.Local).AddTicks(8360), "AQAAAAIAAYagAAAAEP7YH74ltiXitWfkkGBG8QV9puAoxZPNTAEXpgMw9lJ8piPv/Yu2DWl2RMKcbjUsjQ==", "0c77e0e2-6965-4077-abe6-80d675f27675" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b41f4d7-ec05-4867-bdc7-f1273392d4b8", new DateTime(2024, 4, 22, 16, 57, 58, 637, DateTimeKind.Local).AddTicks(8370), "AQAAAAIAAYagAAAAEJeXVxtpH1yi2bl3Q7t07qW6olpdh4Qfuj49yQ3MADp+lZFbIBXqPKUmQpbDkubD+g==", "d97a070d-1e0a-43a1-b453-23afbc806b56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "659b7369-2a85-4874-8dcf-3c20629bddb7", new DateTime(2024, 4, 22, 16, 57, 58, 637, DateTimeKind.Local).AddTicks(8380), "AQAAAAIAAYagAAAAENhIMJExDAsN1vG6Jxo4NBBkno+Mar/xSeKxUDRpPfz3tt4pA1DZT68nqfdupnUOGw==", "97b4122c-871e-4955-a90e-b00d51507e89" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 57, 58, 806, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
