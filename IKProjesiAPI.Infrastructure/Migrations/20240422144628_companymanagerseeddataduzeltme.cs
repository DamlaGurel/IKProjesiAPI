using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class companymanagerseeddataduzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "fc5c76aa-0748-45f0-88fd-140608252266", new DateTime(2024, 4, 22, 17, 46, 28, 506, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "82958cf4-618b-4154-9bcf-1ebef681d26b", new DateTime(2024, 4, 22, 17, 46, 28, 506, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "08ebee4d-a671-480a-9c0d-c9af6a3743ae", new DateTime(2024, 4, 22, 17, 46, 28, 506, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "b53d0664-2276-49ce-aefe-6e06d448230f", new DateTime(2024, 4, 22, 17, 46, 28, 506, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 17, 46, 28, 506, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 17, 46, 28, 506, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 17, 46, 28, 506, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 17, 46, 28, 506, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60872c77-e0be-4149-af40-4ec2cc821c02", new DateTime(2024, 4, 22, 17, 46, 28, 340, DateTimeKind.Local).AddTicks(5630), "AQAAAAIAAYagAAAAEJ7ycg7taRMbWDPb4lmxGdfIeoS62xT+chtwEH8SSf/BDeikjBK/sujO7zQf00XhOA==", "28bee3cf-1bef-44c1-a4f5-eb385abb965e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39b1638f-13bc-4d94-96f7-dc6903f521d4", new DateTime(2024, 4, 22, 17, 46, 28, 340, DateTimeKind.Local).AddTicks(5670), "AQAAAAIAAYagAAAAEDkDkFnS321qfd+ekHwGfIpyZnO90cP85dRuc+WIQ65rqOuRFfRDkzJs0gM9naVtjA==", "66d82563-775f-4110-8083-a84e41553381" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85f09043-a967-45cf-964c-fe72fcc8584f", new DateTime(2024, 4, 22, 17, 46, 28, 340, DateTimeKind.Local).AddTicks(5680), "AQAAAAIAAYagAAAAENk360coPZSPFdcJ3jNJ8rly08fu1rx1H76nIwFXVseFgAPI6gcJkK9hqP4JFHufnw==", "32ee975a-b8d7-4efe-8c22-027df6398d0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cf8d7b5-4925-439d-8d12-10ad771e2ef9", new DateTime(2024, 4, 22, 17, 46, 28, 340, DateTimeKind.Local).AddTicks(5690), "AQAAAAIAAYagAAAAECPsvsFT+Cm4sEZo1YSSlRWLlF4tIfDRjsLUTyu0dulR+ZTnts0yr7dtUa7bI2aFlg==", "96fbddff-4b21-4cb9-9b97-1d10fecc9702" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 17, 46, 28, 506, DateTimeKind.Local).AddTicks(3090));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "b765be68-223b-443b-ac9b-61080b8808a9", new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "49d90cc2-eb62-4490-9bc2-6e684856dd70", new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "07c92b3b-eea7-4f1a-91e4-02abbaacb724", new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5e9967b3-d790-44c8-abf0-19819668ded2", new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "992af79d-5b17-44e2-a385-71c211922fa2", new DateTime(2024, 4, 22, 16, 59, 59, 599, DateTimeKind.Local).AddTicks(8470), "AQAAAAIAAYagAAAAEPWhTcWVnmFY3jKC5vzC/ZSaVo/0PANuuLDGw+Zp/R3DZvXbLp5j8fiuAKcZpMrvUA==", "830a2ecb-8ab9-41f4-9ca8-ba18f6ea947d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "661b4910-9afe-4772-8c4e-003e53322f0d", new DateTime(2024, 4, 22, 16, 59, 59, 599, DateTimeKind.Local).AddTicks(8530), "AQAAAAIAAYagAAAAEJJGdGWws9xP2zmgMHEcue+ltOry4VhfTyROCazLbMyVGwkhub8dRNceTibjSXlBwg==", "05d0353f-c944-4207-a31d-3bfe12e614d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "564248a2-4b8e-455e-a68e-195c9a688914", new DateTime(2024, 4, 22, 16, 59, 59, 599, DateTimeKind.Local).AddTicks(8540), "AQAAAAIAAYagAAAAEL88Cx4cjtk2Orw3+es2Ccw+xMKbA65IjkvJJlyrkwi+wsGISk8aqfv1qqkeRuE/iQ==", "2e315005-799e-4acb-908e-2390f2a69c7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d833d11-72b4-44e6-af3b-9293326a7abc", new DateTime(2024, 4, 22, 16, 59, 59, 599, DateTimeKind.Local).AddTicks(8550), "AQAAAAIAAYagAAAAEKHONtsDBsOTK+B/QHac/Vx7g8K6djSk3kTduEZfiM6cfKtZBB0YQgn1hp1mCq3YBg==", "a3b2b7bd-7660-4118-85de-456bb35b4283" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 16, 59, 59, 769, DateTimeKind.Local).AddTicks(1790));
        }
    }
}
