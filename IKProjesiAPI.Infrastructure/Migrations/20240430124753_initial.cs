using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MersisNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTaxOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoBytes = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeNumber = table.Column<int>(type: "int", nullable: true),
                    FoundationYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartContractDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndContractDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageBytes = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDateOfWork = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDateOfWork = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JobName = table.Column<int>(type: "int", nullable: true),
                    DepartmentName = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemporaryPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    Payment = table.Column<double>(type: "float", nullable: true),
                    Personel_CompanyId = table.Column<int>(type: "int", nullable: true),
                    DaysOffNumber = table.Column<int>(type: "int", nullable: true),
                    Personel_Payment = table.Column<double>(type: "float", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_Personel_CompanyId",
                        column: x => x.Personel_CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdvancePayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelId = table.Column<int>(type: "int", nullable: true),
                    AdvanceType = table.Column<int>(type: "int", nullable: true),
                    TotalAdvance = table.Column<double>(type: "float", nullable: true),
                    MoneyType = table.Column<int>(type: "int", nullable: true),
                    ApprovalType = table.Column<int>(type: "int", nullable: true),
                    ResponseTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancePayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancePayments_AspNetUsers_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelId = table.Column<int>(type: "int", nullable: true),
                    ExpenseType = table.Column<int>(type: "int", nullable: true),
                    TotalExpense = table.Column<double>(type: "float", nullable: true),
                    MoneyType = table.Column<int>(type: "int", nullable: true),
                    ApprovalType = table.Column<int>(type: "int", nullable: true),
                    ResponseTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_AspNetUsers_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TakeOffDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelId = table.Column<int>(type: "int", nullable: true),
                    ApprovalType = table.Column<int>(type: "int", nullable: true),
                    RequestTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DayOffStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DayOffEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DayNumber = table.Column<int>(type: "int", nullable: true),
                    ResponseTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DayOffType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakeOffDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TakeOffDays_AspNetUsers_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Name", "NormalizedName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "f370ec13-a395-4b79-81b9-faeacc59b716", new DateTime(2024, 4, 30, 15, 47, 52, 697, DateTimeKind.Local).AddTicks(1699), null, "SuperAdmin", "SUPERADMİN", null, null },
                    { 2, "e4d3f016-5dda-4a9f-813b-d61d5a811835", new DateTime(2024, 4, 30, 15, 47, 52, 697, DateTimeKind.Local).AddTicks(1738), null, "SiteManager", "SİTEMANAGER", null, null },
                    { 3, "c6256791-6fa8-403d-9b52-a6a959c05ab0", new DateTime(2024, 4, 30, 15, 47, 52, 697, DateTimeKind.Local).AddTicks(1802), null, "CompanyManager", "COMPANYMANAGER", null, null },
                    { 4, "7b54ad00-3aff-4e4b-9df4-f324c7b68843", new DateTime(2024, 4, 30, 15, 47, 52, 697, DateTimeKind.Local).AddTicks(1821), null, "Employee", "EMPLOYEE", null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthPlace", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "DepartmentName", "Discriminator", "Email", "EmailConfirmed", "FinishDateOfWork", "FirstName", "IdentityNumber", "ImageBytes", "JobName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecondLastName", "SecondName", "SecurityStamp", "StartDateOfWork", "Status", "TemporaryPassword", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, 0, null, null, null, "11d1b8de-79fe-40c1-9877-a34c85becad8", new DateTime(2024, 4, 30, 15, 47, 52, 668, DateTimeKind.Local).AddTicks(9088), null, null, "AppUser", "super@admin.com", false, null, "Super", null, null, null, "Admin", false, null, null, null, "admin", "AQAAAAEAACcQAAAAEBnXRNjX30JzH6Jpc/UadbovcQEYXwxWYvbwOOVoF1c/FtzVXd4p9F+urV7s4ohOaA==", null, false, null, null, "bec1a51f-daf1-4a46-95a8-b4bd8557eb1c", null, null, null, false, null, null },
                    { 2, 0, null, null, null, "9dab8c43-5ab9-4100-8e5b-3887cf70cabc", new DateTime(2024, 4, 30, 15, 47, 52, 668, DateTimeKind.Local).AddTicks(9126), null, null, "AppUser", "sitemanager@seeddata.com", false, null, "SiteManagerName", null, null, null, "SiteManagerLastName", false, null, null, null, "sitemanager", "AQAAAAEAACcQAAAAEHhMC4sbvG+iH6kiTJRebo2rGHyNd1X//nHJbiA/EPtaBU2LeldVAReJyEzu03gVNg==", null, false, null, null, "bff38df5-c8c1-4af5-9757-a9ff35af01c2", null, null, null, false, null, null },
                    { 3, 0, null, null, null, "e894393c-786e-4919-9b31-da0c5bcf998b", new DateTime(2024, 4, 30, 15, 47, 52, 668, DateTimeKind.Local).AddTicks(9131), null, null, "AppUser", "companymanager@seeddata.com", false, null, "CompanyManagerName", null, null, null, "CompanyManagerLastName", false, null, null, null, "companymanager", "AQAAAAEAACcQAAAAEI0j5SeccM8jH3DRi4ClZ8mg4ylJ+DSElpXDWRLsOiw49l4fSp2ibMHFNAu79XU3nQ==", null, false, null, null, "3d2b35ad-5734-4264-80ba-22381c9f8b0b", null, null, null, false, null, null },
                    { 4, 0, null, null, null, "6b925550-8609-4ab9-821c-279d7830a92c", new DateTime(2024, 4, 30, 15, 47, 52, 668, DateTimeKind.Local).AddTicks(9137), null, null, "AppUser", "employee@seeddata.com", false, null, "EmployeeName", null, null, null, "EmployeeLastName", false, null, null, null, "employee", "AQAAAAEAACcQAAAAEPiSVMce6gW21ZLvqgktViEUlHbOSUhGBlYZhLV96Zh55zAfPCK3GlG64g74aGGxdQ==", null, false, null, null, "112560e4-e889-4a88-aaca-cb8a2120c52c", null, null, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CompanyName", "CompanyTaxNumber", "CompanyTaxOffice", "CompanyTitle", "CreatedDate", "DeletedDate", "Email", "EmployeeNumber", "EndContractDate", "FoundationYear", "LogoBytes", "MersisNumber", "PhoneNumber", "StartContractDate", "Status", "UpdatedDate" },
                values: new object[] { 1, null, "Company", null, null, null, new DateTime(2024, 4, 30, 15, 47, 52, 697, DateTimeKind.Local).AddTicks(4938), null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 30, 15, 47, 52, 697, DateTimeKind.Local).AddTicks(2312), null, 1, null },
                    { 2, 2, new DateTime(2024, 4, 30, 15, 47, 52, 697, DateTimeKind.Local).AddTicks(2326), null, 1, null },
                    { 3, 3, new DateTime(2024, 4, 30, 15, 47, 52, 697, DateTimeKind.Local).AddTicks(2329), null, 1, null },
                    { 4, 4, new DateTime(2024, 4, 30, 15, 47, 52, 697, DateTimeKind.Local).AddTicks(2332), null, 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePayments_PersonelId",
                table: "AdvancePayments",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Personel_CompanyId",
                table: "AspNetUsers",
                column: "Personel_CompanyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_PersonelId",
                table: "Expenses",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_TakeOffDays_PersonelId",
                table: "TakeOffDays",
                column: "PersonelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvancePayments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "TakeOffDays");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
