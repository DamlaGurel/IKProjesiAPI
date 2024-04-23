using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class companyentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "c0d1b328-76ee-4eff-ae08-02925484ea24", new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "251fe14c-abf1-4978-b11d-dcb8fc56bd43", new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "418ba0db-3e9c-44c3-923b-e90bb2120f5d", new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "e78ca60e-e754-4e07-a6ff-7fdbcf724f92", new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42ef1643-7ee4-43c3-ae7a-5c7b198eafce", new DateTime(2024, 4, 22, 15, 53, 33, 738, DateTimeKind.Local).AddTicks(2780), "AQAAAAIAAYagAAAAEHx83aCzK6pQCQzNaso4bCWzP0F6k5KGZH04prvH+worw9yVxx7OhdGJSn56pixxzw==", "ca8c53f6-a5b6-4737-8e2a-7710bd190c05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e16b17ba-a795-4c07-822e-2a37e3b0951c", new DateTime(2024, 4, 22, 15, 53, 33, 738, DateTimeKind.Local).AddTicks(2830), "AQAAAAIAAYagAAAAEP/g+TyhXCWmfNPIfvCGJ6G+VJc+tdMPGzImjpypBP4dfmiiTWy9lpFOtgFF2zAZkA==", "aa38ad39-30b6-4c35-a0d7-ce0511b8d91c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02a0a89c-71b7-4dca-be86-6d0e312f6774", new DateTime(2024, 4, 22, 15, 53, 33, 738, DateTimeKind.Local).AddTicks(2840), "AQAAAAIAAYagAAAAEIYx2g8bVezU81QcWlWZVARNUIbF3b/nxLJv9qBr4cG0VwUXH5jV+Rl49zneZU2OOQ==", "71304627-26d2-4346-91a6-6401f1534fb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecebd16b-dfd7-4b05-8682-41771d81d490", new DateTime(2024, 4, 22, 15, 53, 33, 738, DateTimeKind.Local).AddTicks(2850), "AQAAAAIAAYagAAAAEHB3N9VvClYB0TWcsX5c9zntl5hSdrarmFY8tD49qjoq3oMpemFY7TNvCsaZ0SXycw==", "5e256dbf-969a-4a1d-adae-cb06ef9207b2" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 15, 53, 33, 911, DateTimeKind.Local).AddTicks(4390));
        }
    }
}
