using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class password : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TemporaryPassword",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemporaryPassword", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "17209cc4-2be1-4c52-83b2-bac3760e20c0", new DateTime(2024, 4, 25, 14, 35, 47, 543, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "815cf494-3d9d-4c0d-90e4-199ce4119c41", new DateTime(2024, 4, 25, 14, 35, 47, 543, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "6d330ad5-b08f-4245-9c2b-78cdb698c2f7", new DateTime(2024, 4, 25, 14, 35, 47, 543, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "6dc7be1d-7ffb-495a-8ac2-b715b07a4d29", new DateTime(2024, 4, 25, 14, 35, 47, 543, DateTimeKind.Local).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 14, 35, 47, 543, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 14, 35, 47, 543, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 14, 35, 47, 543, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 14, 35, 47, 543, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "713352e9-2f83-40ae-8106-9a12e6977bb2", new DateTime(2024, 4, 25, 14, 35, 47, 518, DateTimeKind.Local).AddTicks(568), "AQAAAAEAACcQAAAAEPkp2PLDFK4MgGMaVZp01eA0/GuihE7XXch2iIo9ClEeNylVnOIhRDrhSeJ4LBcsoA==", "d01ce8b9-9379-4603-9657-25deebf270d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69ed952a-eea9-4de3-b395-fa4546a13f96", new DateTime(2024, 4, 25, 14, 35, 47, 518, DateTimeKind.Local).AddTicks(593), "AQAAAAEAACcQAAAAEMbfgQbQYTkZndORjMutPOVyy06pGXpgq8ohCkY9UEnPkYl0BVKqbqmvgfNaNv5xTw==", "338c30a4-41a6-417f-ae79-eabbbf0f3ea1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03f9bf65-81aa-4891-ab38-fbce8fb9d1ce", new DateTime(2024, 4, 25, 14, 35, 47, 518, DateTimeKind.Local).AddTicks(598), "AQAAAAEAACcQAAAAEJ2N6ZB6N4YuDfgDiwK2gC8qgJm77CL1RnearZYMg1/8ZvpKV/Z64iuQEe1KNB4Ikw==", "c3d9691e-960f-4991-b437-b30387083ab5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00bbc7ce-8b6d-448d-ac6b-d8b76921e8b1", new DateTime(2024, 4, 25, 14, 35, 47, 518, DateTimeKind.Local).AddTicks(603), "AQAAAAEAACcQAAAAEMxRXOCBOg7XE5RFjAkrLQ7NRJ7LK+IDXPvC0UHTphALaKmg7zkKhWe68rBEWeoVVQ==", "b1cc2ad3-2664-45bd-8fbc-b5069a36c370" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 14, 35, 47, 543, DateTimeKind.Local).AddTicks(4922));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemporaryPassword");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "22cd204b-e733-4daf-beae-bff9b67ebb4e", new DateTime(2024, 4, 25, 1, 35, 17, 442, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "1857dc19-6b48-4039-be81-018ce928c804", new DateTime(2024, 4, 25, 1, 35, 17, 442, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "623dd0ff-bb08-4ff0-983c-72dc8e043c3c", new DateTime(2024, 4, 25, 1, 35, 17, 442, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "fef9c7ff-aeb4-4862-8cdc-209584af2a99", new DateTime(2024, 4, 25, 1, 35, 17, 442, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 1, 35, 17, 442, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 1, 35, 17, 442, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 1, 35, 17, 442, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 1, 35, 17, 442, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b259225-8852-45da-b129-f9820e4bb3f7", new DateTime(2024, 4, 25, 1, 35, 17, 411, DateTimeKind.Local).AddTicks(2488), "AQAAAAEAACcQAAAAEHELOhYLg5Ik4ReFvXbkw/b3YUVwjNGsRYmE9LEndRUT3HKzXyGUscASriM5rMxEaA==", "47e8abab-1a18-4b49-a4bc-6117734e5284" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d14f184-ad89-4461-9ae0-e41071aff555", new DateTime(2024, 4, 25, 1, 35, 17, 411, DateTimeKind.Local).AddTicks(2543), "AQAAAAEAACcQAAAAEIDE1ZVQq7h+MNOyQ+gFJmICXZRdLF6XilnG6ZGeLT90Rq11+PhF9sbKok5DpLu+Aw==", "7f1d84c0-b650-4880-9b49-4de59fa277d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85fd2a53-622e-4703-b4a4-b70e11a65b3c", new DateTime(2024, 4, 25, 1, 35, 17, 411, DateTimeKind.Local).AddTicks(2550), "AQAAAAEAACcQAAAAEJSgBy60hKvG0WkU1J7/5TF8aERhCEoQemVSHu6TAcFpmLWv4J4+J2Fag1FxYq0V6Q==", "e5d54a4f-e0ee-4c1a-b9d1-774babbb456b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "024a6362-d528-4c97-9629-119d468d0d7a", new DateTime(2024, 4, 25, 1, 35, 17, 411, DateTimeKind.Local).AddTicks(2571), "AQAAAAEAACcQAAAAEFciWr0LTBakHEEZaB+Zvdqxj9H7jGfO79fW48R2dUego4+HSz1QjtVxC7sQG5lq6w==", "e078ef3e-5d11-45ee-9cfb-21aa34bdc244" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 1, 35, 17, 442, DateTimeKind.Local).AddTicks(4796));
        }
    }
}
