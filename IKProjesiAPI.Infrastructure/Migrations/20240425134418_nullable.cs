using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "LogoBytes",
                table: "Companies",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "f134fea6-99a0-4689-8c19-4946dce7a3cc", new DateTime(2024, 4, 25, 16, 44, 17, 319, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "3477efec-ff4f-4a0a-9078-25ba5810783d", new DateTime(2024, 4, 25, 16, 44, 17, 319, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "c9d3ee8d-4760-40e1-ace8-b4bea09eeea7", new DateTime(2024, 4, 25, 16, 44, 17, 319, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "2cd0fdc2-5cd0-4d16-9957-4c0a37f28025", new DateTime(2024, 4, 25, 16, 44, 17, 319, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 44, 17, 319, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 44, 17, 319, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 44, 17, 319, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 44, 17, 319, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fa85a22-ab98-4dc3-92c3-dbea278f95ad", new DateTime(2024, 4, 25, 16, 44, 17, 285, DateTimeKind.Local).AddTicks(3935), "AQAAAAEAACcQAAAAEB2mwS6IXnXcv1dcxXtXdOBZXq7B09mojiqjhEENpNDtbm/pOA3mvh3ElC/tIzye9A==", "8679628c-58a4-4e92-a64e-1fdee8614d91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54bd86e7-33f2-4554-9a74-648cc2fceba6", new DateTime(2024, 4, 25, 16, 44, 17, 285, DateTimeKind.Local).AddTicks(3957), "AQAAAAEAACcQAAAAENULS7KIs9Q8HYMV9JILu4rQtu/1JUdMI4bHvp323FD7We1vMhot/sryBhqb+skLlQ==", "3de9a0bd-98db-4946-804e-008fb2d217ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45efcc63-f86b-4d36-a5af-9fad8fc6d3ac", new DateTime(2024, 4, 25, 16, 44, 17, 285, DateTimeKind.Local).AddTicks(4014), "AQAAAAEAACcQAAAAEPluJFA+/b+hkrdKCiM1HB1oPcU9WlVsfYn2Ss/7T/RO5N52ZaVAL7QMA92DKamxpA==", "3538a6b0-33ef-4437-ae48-2f2ab189f45e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b6b5d0d-95b6-429d-a315-20326fd76920", new DateTime(2024, 4, 25, 16, 44, 17, 285, DateTimeKind.Local).AddTicks(4020), "AQAAAAEAACcQAAAAELxyFDzgqpqQEfNQ0Ije/nRSZ4cAD+7Bh+twDD/NtlEZQg9e6aHuL5v/0A9/qziuhA==", "fc20e1cb-4ac2-41f9-a97d-51be1f11fe0d" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 44, 17, 319, DateTimeKind.Local).AddTicks(4298));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoBytes",
                table: "Companies");

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
