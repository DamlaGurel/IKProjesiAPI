using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class temppasswordupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "TemporaryPassword",
                newName: "OldPassword");

            migrationBuilder.AddColumn<string>(
                name: "NewPassword",
                table: "TemporaryPassword",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "43f9e5e9-dbb7-4cdd-aab8-5bd6c7a02874", new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "00d24a7f-a2eb-4661-a131-f6c88e337c19", new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "6af00890-d976-4b2e-9625-721858188fca", new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "9ec3e6eb-941b-4a04-bdfe-90e29572405b", new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 10, 54, 58, 724, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dceadc5-17c7-447c-b2ce-08bf446c21de", new DateTime(2024, 4, 30, 10, 54, 58, 696, DateTimeKind.Local).AddTicks(1523), "AQAAAAEAACcQAAAAEPcXG1OHlm4Cw6LYNzZ1ZpAYIZRofMXB+LCpVHPotYNxuMq1v7kiMj3VNBiC/ouQ9w==", "02b90a5f-72a8-47a6-9676-a452c52473c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bf9997d-be2e-4e70-9735-8190593b455a", new DateTime(2024, 4, 30, 10, 54, 58, 696, DateTimeKind.Local).AddTicks(1551), "AQAAAAEAACcQAAAAEPZoFNweYf6l06sTIybxuNV9HFN3XSFTJwakRB9rgj8a1FxnMyT2fEr1wCSvYZGtMw==", "be749c89-f04a-46e1-a75f-e879cc8282d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0f4d6c3-4f39-4f74-8140-179fdb315c1f", new DateTime(2024, 4, 30, 10, 54, 58, 696, DateTimeKind.Local).AddTicks(1590), "AQAAAAEAACcQAAAAEEDd30IEgaEfQazIpLn1EIuaUTBs4Mq+jDcIm8DWP+Dp++nWgHPzmtV+WklpEdvlOA==", "af261dd6-a116-4c80-b134-197f5a360989" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a2dfc6b-dce6-4223-ab60-44897c01e457", new DateTime(2024, 4, 30, 10, 54, 58, 696, DateTimeKind.Local).AddTicks(1596), "AQAAAAEAACcQAAAAEFDETfPXtRFf3FLSPyTmd6XES6a2Zc728XbEBYGLsryE229MsbQUeMW8pwMjyaayyQ==", "96d63bfe-6c69-4ec6-aa2c-61cf0fbe31ed" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 10, 54, 58, 725, DateTimeKind.Local).AddTicks(117));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewPassword",
                table: "TemporaryPassword");

            migrationBuilder.RenameColumn(
                name: "OldPassword",
                table: "TemporaryPassword",
                newName: "Password");

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
    }
}
