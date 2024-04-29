using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class sifreguncelleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "TemporaryPassword",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "361afc9c-e596-4eef-a096-c35fc880148c", new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "e4e61c75-2355-4daa-9be6-82a60dbbe7a6", new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "cd3e5b6a-8920-47ab-a5c2-f9c31e916145", new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "20a625f2-323d-46d9-9cdf-11b4bc4db740", new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55bc369c-504f-44f4-aa2b-6ff7d6a1744b", new DateTime(2024, 4, 28, 22, 11, 40, 9, DateTimeKind.Local).AddTicks(6319), "AQAAAAEAACcQAAAAELNQwpwdKsMKRdmPfItlfeAiGEeYcnQa3mvIudwarX18W1Qu5gtiop9nJrq20ITrjg==", "486e680c-eb70-4124-b6d1-6b374bd15576" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a65a3722-fc3b-4139-844c-8bc6c7c51273", new DateTime(2024, 4, 28, 22, 11, 40, 9, DateTimeKind.Local).AddTicks(6336), "AQAAAAEAACcQAAAAEDgY+PEyXmQQw0NkY7zyncAcrrCr5EaMo0cOlk75exozVHJWuwawwWiqnmFWsRC9BQ==", "4c9e9c90-f470-4c4f-b8f0-2caf908927ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71c696d9-09f2-4472-8f92-4ee6991024e6", new DateTime(2024, 4, 28, 22, 11, 40, 9, DateTimeKind.Local).AddTicks(6341), "AQAAAAEAACcQAAAAEH+MIur4aFnD3A3T3TNal5YmgfxygYOK0nWIKKZFZlQlcDY2ilmo8m5Gse8zH8q28Q==", "39cab029-4f18-4e06-b634-7cd1628e92fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c004f83f-7b2f-4d41-a5e7-60ff23c9c027", new DateTime(2024, 4, 28, 22, 11, 40, 9, DateTimeKind.Local).AddTicks(6359), "AQAAAAEAACcQAAAAELzunx64f8GsR3I3aG0MJVFI/Lj8CwarQvOKmUsU2q5V9redT6J91VwfA3Vk/eo9Nw==", "a3128e31-0226-43b1-914b-2bd1183c6648" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 11, 40, 37, DateTimeKind.Local).AddTicks(5553));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TemporaryPassword");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "49136b34-e204-4bd3-b1f8-5f532b118a39", new DateTime(2024, 4, 28, 22, 3, 55, 776, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "d8720c99-ee8b-43c0-b363-6e7f2e5e076d", new DateTime(2024, 4, 28, 22, 3, 55, 776, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "d5a6ee7e-1f80-4264-948b-c76fbd97b8bb", new DateTime(2024, 4, 28, 22, 3, 55, 776, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "21aa488d-cc73-4257-b0d8-cc09ac268066", new DateTime(2024, 4, 28, 22, 3, 55, 776, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 3, 55, 776, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 3, 55, 776, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 3, 55, 776, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 3, 55, 776, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca656bd9-0c4d-4f68-a11d-00ed49ca5b98", new DateTime(2024, 4, 28, 22, 3, 55, 753, DateTimeKind.Local).AddTicks(2904), "AQAAAAEAACcQAAAAEGGfaheESC13ImGioNOdEvDKJh3fEWzEBkg1LLoeHQrVvpRa2NIalcxrhNzOIz041Q==", "80843dbd-9556-490b-ba68-1d9188ebc517" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dfd2cf3-b758-4f1b-9bbc-ab5b9a2005ba", new DateTime(2024, 4, 28, 22, 3, 55, 753, DateTimeKind.Local).AddTicks(2917), "AQAAAAEAACcQAAAAEMARnVLx3kEozy6n3PYuohPOZHmyv8NwFgPSdO6dcciQoLtZFbJhKsamJEs+scJIAw==", "d4fa35b5-ed99-4377-867d-fb0c9e55a9fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50d58a72-d4bf-47cc-be34-ebdc8a3e3159", new DateTime(2024, 4, 28, 22, 3, 55, 753, DateTimeKind.Local).AddTicks(2935), "AQAAAAEAACcQAAAAEFfjORb7TYlYsNJHuy4F3sFF6110/QZt1+U1mnNiUm2eA2etM8z4Req9mYGAHtCvgQ==", "5560cbd4-09ae-4084-a9dd-315c6c5b6b5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1ea3f67-7c2e-4c90-a78a-c81d2673c40d", new DateTime(2024, 4, 28, 22, 3, 55, 753, DateTimeKind.Local).AddTicks(2940), "AQAAAAEAACcQAAAAEGYk0LHV7SQEVfLK8w4iGzjpFBId1KISNK3jFrXv3GSU6Qve6Ji8PMa/a25ogZP1xA==", "85273929-7e97-4662-bda1-c5d38415e25c" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 22, 3, 55, 776, DateTimeKind.Local).AddTicks(9031));
        }
    }
}
