using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class rolduzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "31dcc273-4855-4763-9989-583c92e12985", new DateTime(2024, 4, 22, 1, 56, 27, 200, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "17f38760-a001-403e-94c2-5a994170ad56", new DateTime(2024, 4, 22, 1, 56, 27, 200, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5ffee499-6b0d-4dc9-9340-1551c8a31734", new DateTime(2024, 4, 22, 1, 56, 27, 200, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "b36db89d-fa27-4f9f-8a1a-ea153e63f7ac", new DateTime(2024, 4, 22, 1, 56, 27, 200, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 1, 56, 27, 200, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7e39f4f-7e7e-424b-b4f1-b5652309dd89", new DateTime(2024, 4, 22, 1, 56, 27, 192, DateTimeKind.Local).AddTicks(7439), "AQAAAAEAACcQAAAAELctk/rKJtHhJp1b6n4KBBZfNkoXQVNauAebCrO/0THN9fYCctZBcHMf2ycRJVUtqw==", "6d116ad6-a9a2-45c0-b619-a0cc742e08f4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
