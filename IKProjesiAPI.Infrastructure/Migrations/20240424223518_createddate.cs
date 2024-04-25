using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class createddate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Companies",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUserRoles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "d66945cd-9be5-4510-a688-be570e208ba4", new DateTime(2024, 4, 25, 1, 26, 28, 71, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "929135ec-0fed-4254-8abb-61106283568d", new DateTime(2024, 4, 25, 1, 26, 28, 71, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "a7052993-27e5-47b3-ab0c-a38511602cc7", new DateTime(2024, 4, 25, 1, 26, 28, 71, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "20a91dad-54d5-4838-9055-9cd19f37a785", new DateTime(2024, 4, 25, 1, 26, 28, 71, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 1, 26, 28, 71, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 1, 26, 28, 71, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 1, 26, 28, 71, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 1, 26, 28, 71, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54ec8b8f-dcac-4bf8-bcca-65b46305f901", new DateTime(2024, 4, 25, 1, 26, 28, 45, DateTimeKind.Local).AddTicks(2034), "AQAAAAEAACcQAAAAELeKw/PFFAIqP13nahJBUDtLH+gOgSXJM2wJHlt0SqkuHqnviFdkPOqi7usAu+HqlA==", "7578553b-7a03-44d8-b17b-4e68d088cfe0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ad051ba-e00d-4023-a645-3013940eb97c", new DateTime(2024, 4, 25, 1, 26, 28, 45, DateTimeKind.Local).AddTicks(2061), "AQAAAAEAACcQAAAAEHRUph0J7XBEJ9LNNSVPw96Ya/MGVPStLYMyncYKcwHs23imCiKHJvx9FxzQL5RqDA==", "d1b37f27-2a30-447b-b39b-6507fb8cb61d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88ca6663-11c5-4afa-a8f0-a0345b665f73", new DateTime(2024, 4, 25, 1, 26, 28, 45, DateTimeKind.Local).AddTicks(2066), "AQAAAAEAACcQAAAAELF4Yz3hJLyglqajVrkZKupp5ni084zd/9UHAXcSVqqLwNluxxPA580LCNBER/DkTg==", "24ca0af3-a6f1-462e-9887-4c0ffea9eea0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea95a5d9-b6cb-454d-918f-f29ccb4b280f", new DateTime(2024, 4, 25, 1, 26, 28, 45, DateTimeKind.Local).AddTicks(2077), "AQAAAAEAACcQAAAAEBwTna7x/7b3+piGjR08K/PG7/1NSZuNJZE+l6l/4Yzz2Hkk7JBuFuUCSp5d2535dA==", "c1df9572-fef1-428c-9266-10b0172ee013" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 1, 26, 28, 71, DateTimeKind.Local).AddTicks(6663));
        }
    }
}
