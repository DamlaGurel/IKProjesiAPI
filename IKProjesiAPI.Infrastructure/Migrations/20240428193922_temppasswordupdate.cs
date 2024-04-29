using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class temppasswordupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "933452ac-5e6d-4731-acd7-7d1c2bb71f12", new DateTime(2024, 4, 28, 22, 35, 41, 911, DateTimeKind.Local).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "6189f6a8-6f6e-4bc4-85f0-0e29481c5d46", new DateTime(2024, 4, 28, 22, 35, 41, 911, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "2200f9a4-941d-44b3-a5bb-df7d0693fe1b", new DateTime(2024, 4, 28, 22, 35, 41, 911, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "1d116f96-f5cb-44be-a8d5-2e4fb7c8c584", new DateTime(2024, 4, 28, 22, 35, 41, 911, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 35, 41, 911, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 35, 41, 911, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 35, 41, 911, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 35, 41, 911, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8094a1be-7ce5-440b-a017-9ff406a79ae5", new DateTime(2024, 4, 28, 22, 35, 41, 887, DateTimeKind.Local).AddTicks(5323), "AQAAAAEAACcQAAAAECaj7QMc5/NGhPH41JqcjaIh0UJ/mBO17vvigqjifzGGzlcKXpgl5RZj8q6bSdaOsw==", "10532d85-df2a-47ba-a288-bae42c9bb840" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dee34a5-cf76-45ef-9c27-43433c24eb29", new DateTime(2024, 4, 28, 22, 35, 41, 887, DateTimeKind.Local).AddTicks(5336), "AQAAAAEAACcQAAAAEFLxw0FHohPTrYs5uHGgq5zAHEc9u6MGlFQaOSB2daJ3LwIa5X/l2qC5Y46NM6A5LA==", "c07f6374-57d2-43ee-8893-9043584ab274" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e0d73a9-40a0-4a7e-83ad-0125eccc2405", new DateTime(2024, 4, 28, 22, 35, 41, 887, DateTimeKind.Local).AddTicks(5342), "AQAAAAEAACcQAAAAEJOg9tzBlgYj5m5zL779UpMj40z35T26ddSHJFuaB6SGG6vzYm1RZ/zxVHcGZ0iAFg==", "4f35a3e4-de7a-489a-b72a-848d17301e51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0f9d326-b722-4bb8-8af4-00ad07eaa414", new DateTime(2024, 4, 28, 22, 35, 41, 887, DateTimeKind.Local).AddTicks(5355), "AQAAAAEAACcQAAAAEK3OyeoRbDAzpn4XH1cJvCsjHY4mNcKJ6kEGMw8nRQwfsIIugqDQjFkqq2zXo2qGlw==", "66cbcb7e-72e9-40af-9bb1-aa8af8281182" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 35, 41, 911, DateTimeKind.Local).AddTicks(1981));
        }
    }
}
