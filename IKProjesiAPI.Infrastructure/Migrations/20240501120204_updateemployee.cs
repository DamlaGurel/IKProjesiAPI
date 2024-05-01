using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IKProjesiAPI.Infrastructure.Migrations
{
    public partial class updateemployee : Migration
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
                    CompanyManagerId = table.Column<int>(type: "int", nullable: true),
                    DaysOffNumber = table.Column<int>(type: "int", nullable: true),
                    Employee_Payment = table.Column<double>(type: "float", nullable: true),
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
                        name: "FK_AspNetUsers_AspNetUsers_CompanyManagerId",
                        column: x => x.CompanyManagerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdvancePayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_AdvancePayments_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
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
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Expenses_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TakeOffDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_TakeOffDays_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Name", "NormalizedName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "a5572f26-b6ca-4fbf-b37f-f73fb512a4a8", new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(5819), null, "SuperAdmin", "SUPERADMİN", null, null },
                    { 2, "dbba606f-56b4-438e-8039-cd73da0835ad", new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(5971), null, "SiteManager", "SİTEMANAGER", null, null },
                    { 3, "086092c3-80e8-4510-b559-70317cbeb71b", new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(5995), null, "CompanyManager", "COMPANYMANAGER", null, null },
                    { 4, "c28ad066-bdba-4dba-9475-e51abcda1bcd", new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(6007), null, "Employee", "EMPLOYEE", null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthPlace", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "DepartmentName", "Discriminator", "Email", "EmailConfirmed", "FinishDateOfWork", "FirstName", "IdentityNumber", "ImageBytes", "JobName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecondLastName", "SecondName", "SecurityStamp", "StartDateOfWork", "Status", "TemporaryPassword", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, 0, null, null, null, "948fa84e-4816-4705-8956-945f4ac0d0a5", new DateTime(2024, 5, 1, 15, 2, 3, 766, DateTimeKind.Local).AddTicks(7871), null, null, "AppUser", "super@admin.com", false, null, "Super", null, null, null, "Admin", false, null, null, null, "admin", "AQAAAAEAACcQAAAAENGvNHB9+uT/fcUwoYSmD2ch58bqB1Madq85n8NKu9P9CMY/WjGqoRQhPzGb245g1A==", null, false, null, null, "009256f4-7b63-4f99-9e6b-79e2941845ff", null, null, null, false, null, null },
                    { 2, 0, null, null, null, "1887707b-cf6f-4423-a283-f3e14ddd7f38", new DateTime(2024, 5, 1, 15, 2, 3, 766, DateTimeKind.Local).AddTicks(7897), null, null, "AppUser", "sitemanager@seeddata.com", false, null, "SiteManagerName", null, null, null, "SiteManagerLastName", false, null, null, null, "sitemanager", "AQAAAAEAACcQAAAAEJF32u7XpiTaag/DwROX/W+9dCx/CzGNX5BsjU2meqya2k2ikOAu6FYkilqmwkNlZQ==", null, false, null, null, "13622f0b-54a3-4721-88d2-3fe2a9c1a2ae", null, null, null, false, null, null },
                    { 3, 0, null, null, null, "5d18f89b-0c89-4f9c-a466-2427d7c4ad2d", new DateTime(2024, 5, 1, 15, 2, 3, 766, DateTimeKind.Local).AddTicks(7906), null, null, "AppUser", "companymanager@seeddata.com", false, null, "CompanyManagerName", null, null, null, "CompanyManagerLastName", false, null, null, null, "companymanager", "AQAAAAEAACcQAAAAEDRnqNwu45rPKsqY0d7MyxftXPvKxMtYMFjYGpEMcS0Ifwov7TlHvtNfYEjclMLuSQ==", null, false, null, null, "62c84b35-9e48-4290-a311-e3b5239d3f60", null, null, null, false, null, null },
                    { 4, 0, null, null, null, "d831365a-de57-4d35-adae-985dfade0597", new DateTime(2024, 5, 1, 15, 2, 3, 766, DateTimeKind.Local).AddTicks(7915), null, null, "AppUser", "employee@seeddata.com", false, null, "EmployeeName", null, null, null, "EmployeeLastName", false, null, null, null, "employee", "AQAAAAEAACcQAAAAEKZc1SETM4KD6m350/e4cuccxKLZKJpGSoos3F9I7EJVElxBBdj6ZGC4uePkoZmREA==", null, false, null, null, "b6478c05-2d9c-418e-aa9d-eb76027b372e", null, null, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CompanyName", "CompanyTaxNumber", "CompanyTaxOffice", "CompanyTitle", "CreatedDate", "DeletedDate", "Email", "EmployeeNumber", "EndContractDate", "FoundationYear", "LogoBytes", "MersisNumber", "PhoneNumber", "StartContractDate", "Status", "UpdatedDate" },
                values: new object[] { 1, null, "Company", null, null, null, new DateTime(2024, 5, 1, 15, 2, 3, 808, DateTimeKind.Local).AddTicks(503), null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(6850), null, 1, null },
                    { 2, 2, new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(6867), null, 1, null },
                    { 3, 3, new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(6872), null, 1, null },
                    { 4, 4, new DateTime(2024, 5, 1, 15, 2, 3, 807, DateTimeKind.Local).AddTicks(6876), null, 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePayments_EmployeeId",
                table: "AdvancePayments",
                column: "EmployeeId");

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
                name: "IX_AspNetUsers_CompanyManagerId",
                table: "AspNetUsers",
                column: "CompanyManagerId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_EmployeeId",
                table: "Expenses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TakeOffDays_EmployeeId",
                table: "TakeOffDays",
                column: "EmployeeId");
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
