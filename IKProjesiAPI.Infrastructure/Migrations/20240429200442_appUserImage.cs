using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class appUserImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageBytes",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "b891c4b6-4b86-4f3f-be5c-d620dfbc7d71", new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "e763e72c-1ac8-4fcb-9df7-350742226bce", new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "833eaddc-1be7-41e0-815f-0d6bb63804d9", new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "8210545f-9b22-4450-85f2-f9c20adea728", new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 23, 4, 41, 307, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 23, 4, 41, 308, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44a6fedf-9053-45dd-b35e-2864cc1688ad", new DateTime(2024, 4, 29, 23, 4, 41, 232, DateTimeKind.Local).AddTicks(4969), "AQAAAAEAACcQAAAAEFpRK//LEImwBrH997Zxofk86bZUxlh1xarAgFztSYSeTJoVcf/7WnZD1/fOcObIIw==", "cb40b178-19ba-4bc4-af2d-1b89544c725b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35edcede-10f6-4f5c-bebb-a7ff1fab4e39", new DateTime(2024, 4, 29, 23, 4, 41, 232, DateTimeKind.Local).AddTicks(5022), "AQAAAAEAACcQAAAAEBlcrwnV909WwauqvMglxCRytW9boQniZGEopEs0xcJ+Q2hwVVw+y8tyKSw6d6k/og==", "4d5af208-4638-4204-941f-5bd276a49277" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b2ff46f-5919-453a-911a-f638c569a5f6", new DateTime(2024, 4, 29, 23, 4, 41, 232, DateTimeKind.Local).AddTicks(5135), "AQAAAAEAACcQAAAAEIb7A9F5ymjDWCn/Qo3NiDOGbamx38HgfJMK+DRtTNFthApXOK3BDnYDKvL9F7M/SA==", "db828cab-752b-4b3f-8344-7fac7d6f3ec4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c36f792c-0ac3-4ea0-b9da-d1294f786e80", new DateTime(2024, 4, 29, 23, 4, 41, 232, DateTimeKind.Local).AddTicks(5161), "AQAAAAEAACcQAAAAEMLN8gp/fybQkp1ghFxkjz+jTAVZ7K0wT7eCbpNyd/gN1uhBkQVcExTLPuD9+SwSNA==", "9c7247ce-6adb-48cc-9ad8-2f7e6ccb709c" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 23, 4, 41, 308, DateTimeKind.Local).AddTicks(1556));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageBytes",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "76eded09-75dc-4ed2-867b-14e8c6db9ccd", new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "eae178b4-e662-45d8-a65f-f74507993394", new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "c557a0f0-6a61-4163-9fc4-0037ac391551", new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "27f4890c-b33b-4239-bae2-af65353023f5", new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96f04e99-4d49-4fbc-ad93-2b7db175bf85", new DateTime(2024, 4, 29, 15, 13, 31, 919, DateTimeKind.Local).AddTicks(9165), "AQAAAAEAACcQAAAAELykxw7v/p8v98QWPJjrwiLfj287IRaNVCWMEAS9wCwso2asHnvV7LiVYf1KDxNeWA==", "e1eb51e0-9d07-4421-94d1-2bf22bc69639" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2785776-3a83-4a54-9fad-d19c92da72c9", new DateTime(2024, 4, 29, 15, 13, 31, 919, DateTimeKind.Local).AddTicks(9185), "AQAAAAEAACcQAAAAEFGrMmJtqGctYfNnajIKQWKlAqe/mzFOyr4nU3KoaehlZPpfJzBCLuGp/Tcwt/mTGw==", "d5356b2e-f16b-4605-9ed5-6cc648997bb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd9aedf6-a379-4245-82d9-aa51b08b4f1f", new DateTime(2024, 4, 29, 15, 13, 31, 919, DateTimeKind.Local).AddTicks(9207), "AQAAAAEAACcQAAAAEOkzc8b6Lmzm7PHU3PiBJ4AnaVmtbhVK17i3TvPxw+3jFJPGBwUr/vGwZ5HlbcOcIQ==", "d7c29ac5-d38b-4981-95a1-92fe51cbbe03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f552381-db57-45e2-8f26-dd7330613257", new DateTime(2024, 4, 29, 15, 13, 31, 919, DateTimeKind.Local).AddTicks(9215), "AQAAAAEAACcQAAAAEKXbVb2YJ51HERj7BzPqXNZtMizB5vb8s1OvehBzJpFNbZUpxrMC52QfpTx9jo0P8g==", "c7bfc5f4-d033-4613-bb6f-0f020d3aabc8" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 15, 13, 31, 949, DateTimeKind.Local).AddTicks(7632));
        }
    }
}
