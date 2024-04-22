using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class tabloayirmadeneme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Company_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AppUserFirstName",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.CreateTable(
                name: "CompanyManager",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyManager", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyManager_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyManager_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteManager",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteManager", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiteManager_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "0a1fe396-0fc4-41a0-96df-dced0ae0ce16", new DateTime(2024, 4, 20, 13, 31, 25, 857, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "569845ad-80d9-41d8-9def-415576aa703b", new DateTime(2024, 4, 20, 13, 31, 25, 857, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "669d2603-0763-4cb6-9d87-c1dd7f685958", new DateTime(2024, 4, 20, 13, 31, 25, 857, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "ed3e58fe-ff15-4efa-a996-8d43a1dc4465", new DateTime(2024, 4, 20, 13, 31, 25, 857, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 31, 25, 857, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b12198e4-a595-446b-8fde-f022d4a23ff2", new DateTime(2024, 4, 20, 13, 31, 25, 814, DateTimeKind.Local).AddTicks(8530), "AQAAAAIAAYagAAAAEM2iHhNAHBexQ3/Zigqq7VYZR45/DC6iLpx1dyvNF7FArIKeP/plu9hJto5OMXuGCg==", "23dd6b84-0e15-46f9-87ae-e56c73682a5d" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyManager_CompanyId",
                table: "CompanyManager",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyManager");

            migrationBuilder.DropTable(
                name: "SiteManager");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "AppUserFirstName");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "83c72b42-2c49-472f-b07a-02a1723f5d8c", new DateTime(2024, 4, 20, 12, 48, 21, 255, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "11f73161-2b92-4d42-9089-7dc9f754d037", new DateTime(2024, 4, 20, 12, 48, 21, 255, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5ce0e6c7-9762-4697-b42b-10055ffd4b61", new DateTime(2024, 4, 20, 12, 48, 21, 255, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "463fc91e-8126-440f-9b71-c356580ebd1b", new DateTime(2024, 4, 20, 12, 48, 21, 255, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 12, 48, 21, 255, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthPlace", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "DepartmentName", "Discriminator", "Email", "EmailConfirmed", "FinishDateOfWork", "AppUserFirstName", "IdentityNumber", "ImagePath", "JobName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecondLastName", "SecondName", "SecurityStamp", "StartDateOfWork", "Status", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[] { 1, 0, null, null, null, "1eb21920-7af0-42c2-9357-d5aab0ee4e83", new DateTime(2024, 4, 20, 12, 48, 21, 212, DateTimeKind.Local).AddTicks(8220), null, null, "AppUser", "super@admin.com", false, null, "Super", null, null, null, "Admin", false, null, null, null, "admin", "AQAAAAIAAYagAAAAEPRln7JG00hlZzdeaCfSFKLEmgI/kzhw6BMlqlwkbRyh6QNk55WsO4h3+/2O47HwYw==", null, false, null, null, "3e3677a5-ece8-4524-898c-be1c2502f8e3", null, null, false, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Company_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
