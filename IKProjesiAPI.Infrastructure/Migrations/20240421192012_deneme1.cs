using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class deneme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyManager");

            migrationBuilder.DropTable(
                name: "SiteManager");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

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
                values: new object[] { "aa553496-0db4-4f61-99fb-16f8b13dc029", new DateTime(2024, 4, 21, 22, 20, 11, 947, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "e8847fea-b7b2-46ba-b7b3-fa116307562e", new DateTime(2024, 4, 21, 22, 20, 11, 947, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5e79a231-a8ad-4c0c-84ef-1ce25c23cde2", new DateTime(2024, 4, 21, 22, 20, 11, 947, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "2d743f39-4e2e-43bd-ba8a-6a5c6fa88090", new DateTime(2024, 4, 21, 22, 20, 11, 947, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 22, 20, 11, 947, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthPlace", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "DepartmentName", "Discriminator", "Email", "EmailConfirmed", "FinishDateOfWork", "FirstName", "IdentityNumber", "ImagePath", "JobName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecondLastName", "SecondName", "SecurityStamp", "StartDateOfWork", "Status", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[] { 1, 0, null, null, null, "5333f5f2-d4cc-47ee-a478-b658fc21d37b", new DateTime(2024, 4, 21, 22, 20, 11, 906, DateTimeKind.Local).AddTicks(270), null, null, "AppUser", "super@admin.com", false, null, "Super", null, null, null, "Admin", false, null, null, null, "admin", "AQAAAAIAAYagAAAAEGus37OGDZ51vaA11svIr+zrsWTSB7HcYHVbzgi5V565kC16/LKpDjSOuu+Onvj4Sw==", null, false, null, null, "7a1c018b-88c1-4fb2-b4b4-1bf541021b1e", null, null, false, null, null });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "5e9a3ae2-6947-407c-a7c4-42eb944d2f94", new DateTime(2024, 4, 21, 22, 18, 43, 692, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "c9bc7d39-2a82-44d8-86ae-05641a2581b5", new DateTime(2024, 4, 21, 22, 18, 43, 692, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "b89a8390-6350-4773-960d-758579184162", new DateTime(2024, 4, 21, 22, 18, 43, 692, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "34276aad-cfbf-4ed2-8e6d-081e5bf87e87", new DateTime(2024, 4, 21, 22, 18, 43, 692, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 22, 18, 43, 692, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d8525dd-6b6f-4e0c-9da6-7c640cb2fd5d", new DateTime(2024, 4, 21, 22, 18, 43, 650, DateTimeKind.Local).AddTicks(6660), "AQAAAAIAAYagAAAAEDIAJiRDsMpZV4HA97s9R7K0ptWOLNeJSLZ7SC1tPig1gCHuE+uySiVLII073A4xFw==", "4e45a42e-ce12-4a20-a7ba-c18153d2c4a4" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyManager_CompanyId",
                table: "CompanyManager",
                column: "CompanyId");
        }
    }
}
