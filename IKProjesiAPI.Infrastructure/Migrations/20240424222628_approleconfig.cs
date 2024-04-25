using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class approleconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "f175a7e6-49ec-4225-9be7-4db7b446a328", new DateTime(2024, 4, 23, 17, 26, 4, 209, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "4e551337-e434-4d71-b7b3-59990a9dacf9", new DateTime(2024, 4, 23, 17, 26, 4, 209, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "4a457a61-937a-451b-9759-b1db7d8e07e4", new DateTime(2024, 4, 23, 17, 26, 4, 209, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "a1b785af-6636-49fb-85c8-d9ccfe021e37", new DateTime(2024, 4, 23, 17, 26, 4, 209, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 23, 17, 26, 4, 209, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 23, 17, 26, 4, 209, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 23, 17, 26, 4, 209, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 23, 17, 26, 4, 209, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47a7540d-72a7-445d-a61a-cdc3e88343ec", new DateTime(2024, 4, 23, 17, 26, 4, 180, DateTimeKind.Local).AddTicks(6959), "AQAAAAEAACcQAAAAEECC1UdRiDrbv1b254m1CaP6xb+x3g58K8XDz//wOBCobohyrWbn1aySc3YNnPXqAA==", "887777be-0667-4143-85f4-23b4c3cc6072" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75f91072-a944-4275-b580-d57bae4b53bd", new DateTime(2024, 4, 23, 17, 26, 4, 180, DateTimeKind.Local).AddTicks(6979), "AQAAAAEAACcQAAAAEE7TKq6H+/PfktZnf/9b2+HzT8NGhuzP0lH9INXDAAhbSknrmddQkeW7qLXIVcVSHw==", "fe2656d2-6aab-4744-b111-f049ff5a3af9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a7e2829-3754-416b-9f3e-e7f1d38c147d", new DateTime(2024, 4, 23, 17, 26, 4, 180, DateTimeKind.Local).AddTicks(6984), "AQAAAAEAACcQAAAAEHcTbDCunk5k88r4IvJich8dElhFz9icf2fdh30HCmVUoC9nDMoSNLkQ60zegFoB0A==", "99fc6f4d-073d-47ba-a9fe-69c81fd54321" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66c2f1c7-9488-40e3-9ff9-d24383b420b6", new DateTime(2024, 4, 23, 17, 26, 4, 180, DateTimeKind.Local).AddTicks(7001), "AQAAAAEAACcQAAAAEO9Xyd5RBggjO9jmw+AqckKhtsu5VfIOJ69ilbbvi3fdPVnijy/6gKCTF0vNflG4Ag==", "768890b4-1b12-4a68-ac32-49668c67921f" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 23, 17, 26, 4, 209, DateTimeKind.Local).AddTicks(2691));
        }
    }
}
