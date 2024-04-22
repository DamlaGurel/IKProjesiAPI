using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "d21275be-8efb-44d4-840f-fd726e53c239", new DateTime(2024, 4, 19, 21, 58, 5, 318, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "470ce04f-1a82-4fd6-89c8-6fa7d2ab16c0", new DateTime(2024, 4, 19, 21, 58, 5, 318, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "eaa3cb01-3ddd-4ba8-b66e-33ba07b51c7f", new DateTime(2024, 4, 19, 21, 58, 5, 318, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "4db165c8-9a07-4758-8ba8-f755bdb17d88", new DateTime(2024, 4, 19, 21, 58, 5, 318, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 21, 58, 5, 318, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63e6fc43-4ab4-4fd3-b721-64ba7d6abf7d", new DateTime(2024, 4, 19, 21, 58, 5, 311, DateTimeKind.Local).AddTicks(5082), "AQAAAAEAACcQAAAAECbNXiYETZ1zJkuGAVB0W7W2C7xEPsE6nCqYHJKdK+RZtgFmRJ1Fm9pL2okDSBQV3Q==", "6e29e77b-9c8e-4917-af27-a3ce3e5e694b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5f4a7ef6-0ce1-4906-93d1-734659f324c9", new DateTime(2024, 4, 19, 18, 43, 19, 267, DateTimeKind.Local).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "6d57d311-9a80-4eeb-af94-fe0f81dcc816", new DateTime(2024, 4, 19, 18, 43, 19, 267, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "46754cc6-789b-4a84-b2e3-aa2315ea18fe", new DateTime(2024, 4, 19, 18, 43, 19, 267, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "11fec0ee-a206-4b35-99a8-d46dac113d9d", new DateTime(2024, 4, 19, 18, 43, 19, 267, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 18, 43, 19, 267, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2294084b-5514-4e97-be27-9c0f9cf9d813", new DateTime(2024, 4, 19, 18, 43, 19, 258, DateTimeKind.Local).AddTicks(9295), "AQAAAAEAACcQAAAAENSLVuglVlO+S1g8TXTX1yh2N7kyg3JBRwECg0b+fayYW2WJr/ZwmcIY1tq8o6HDnw==", "9b9d0727-e926-4c53-97c2-b7642808a2b6" });
        }
    }
}
