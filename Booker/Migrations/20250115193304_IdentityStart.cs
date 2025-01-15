using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Booker.Migrations
{
    /// <inheritdoc />
    public partial class IdentityStart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_UserID",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Items",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_UserID",
                table: "Items",
                newName: "IX_Items_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Items",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.DropTable(
                name: "Users"
            );

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "School", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user1", 0, "ec040d70-efb8-42af-ba55-ccf0c2e12f86", "user1@gmail.com", false, false, null, null, null, null, null, false, "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png", "Śl.TZN", "c8f1f1e7-2548-4920-b607-401955c3c905", false, "user1" },
                    { "user2", 0, "eda30aa1-e0c4-4f6a-b34c-18ea47687fa4", "user2@gmail.com", false, false, null, null, null, null, null, false, "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png", "Śl.TZN", "6157fefa-120e-4c30-bccd-c718eb02e12f", false, "user2" },
                    { "user3", 0, "afe31083-b767-4abc-b1af-a896dec7c9f3", "user3@gmail.com", false, false, null, null, null, null, null, false, "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png", "Śl.TZN", "786841dd-94c5-4d01-a0f9-54ed37121da1", false, "user3" },
                    { "user4", 0, "94ab44ba-4101-4562-ab5b-4a9fa6d1a0eb", "user4@gmail.com", false, false, null, null, null, null, null, false, "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png", "Śl.TZN", "9a2d81d8-127e-4368-817f-b85a2ff57402", false, "user4" },
                    { "user5", 0, "22c84f75-c0ea-4292-8cec-e1e8dba8a32f", "user5@gmail.com", false, false, null, null, null, null, null, false, "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png", "Śl.TZN", "960e8b8a-53e6-4e62-9326-b986420a25d1", false, "user5" }
                });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 41, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7254), 66.571428571428571428571428571m, "user1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 64, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7289), 30.428571428571428571428571429m, "user2" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 60, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7293), 30.857142857142857142857142857m, "user3" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 56, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7296), 38.571428571428571428571428571m, "user4" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 25, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7300), 68.142857142857142857142857143m, "user5" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 24, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7304), 84.71428571428571428571428571m, "user1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 53, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7307), 47.428571428571428571428571429m, "user2" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 10, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7310), 67.714285714285714285714285714m, "user3" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 62, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7314), 78.285714285714285714285714286m, "user4" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 57, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7316), 52m, "user5" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 7, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7320), 49.428571428571428571428571429m, "user1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 64, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7323), 80.57142857142857142857142857m, "user2" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 30, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7327), 60.285714285714285714285714286m, "user3" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 2, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7330), 72m, "user4" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 65, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7333), 21.857142857142857142857142857m, "user5" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 49, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7336), 68.142857142857142857142857143m, "user1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 11, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7339), 34.714285714285714285714285714m, "user2" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 54, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7343), 26.714285714285714285714285714m, "user3" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 16, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7346), 53.857142857142857142857142857m, "user4" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 36, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7348), 46m, "user5" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 7, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7351), 64m, "user1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 27, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7354), 35m, "user2" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 14, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7357), 40.857142857142857142857142857m, "user3" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 34, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7360), 58.857142857142857142857142857m, "user4" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 57, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7363), 65.142857142857142857142857143m, "user5" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 64, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7366), 67.857142857142857142857142857m, "user1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 50, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7369), 70m, "user2" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 60, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7372), 61.857142857142857142857142857m, "user3" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 48, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7374), 70.714285714285714285714285714m, "user4" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 50, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7377), 38m, "user5" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 17, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7381), 28m, "user1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateTime", "Price", "UserId" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7383), 65.428571428571428571428571429m, "user2" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 50, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7388), 20.714285714285714285714285714m, "user3" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateTime", "Price", "UserId" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7392), 36.714285714285714285714285714m, "user4" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 73, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7395), 69.857142857142857142857142857m, "user5" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 8, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7398), 78.142857142857142857142857143m, "user1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "DateTime", "Price", "UserId" },
                values: new object[] { 68, new DateTime(2025, 1, 15, 20, 33, 4, 508, DateTimeKind.Local).AddTicks(7401), 79m, "user2" });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Items_AspNetUsers_UserId",
                table: "Items",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_AspNetUsers_UserId",
                table: "Items");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Items",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Items_UserId",
                table: "Items",
                newName: "IX_Items_UserID");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 73, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9369), 43m, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 3, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9412), 52.428571428571428571428571429m, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 40, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9416), 56.857142857142857142857142857m, 3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 21, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9419), 35m, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 56, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9422), 67.285714285714285714285714286m, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 61, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9425), 31m, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 35, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9428), 38.714285714285714285714285714m, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 72, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9432), 63.714285714285714285714285714m, 3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 43, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9434), 62.714285714285714285714285714m, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 56, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9437), 56.714285714285714285714285714m, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 21, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9440), 20.571428571428571428571428571m, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 10, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9442), 49.714285714285714285714285714m, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 23, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9445), 45.142857142857142857142857143m, 3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 9, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9448), 32.285714285714285714285714286m, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 34, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9451), 74.285714285714285714285714286m, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 2, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9455), 81.57142857142857142857142857m, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 44, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9458), 46.285714285714285714285714286m, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 44, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9461), 68.285714285714285714285714286m, 3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 70, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9463), 61.142857142857142857142857143m, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 56, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9466), 36.857142857142857142857142857m, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 74, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9469), 75.428571428571428571428571429m, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 26, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9471), 61.285714285714285714285714286m, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 41, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9475), 73m, 3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 26, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9477), 69.571428571428571428571428571m, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 56, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9480), 83.14285714285714285714285714m, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 55, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9483), 53.714285714285714285714285714m, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 51, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9510), 74.285714285714285714285714286m, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 62, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9555), 25.142857142857142857142857143m, 3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 19, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9558), 20.428571428571428571428571429m, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 25, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9561), 22m, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 71, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9564), 69.571428571428571428571428571m, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateTime", "Price", "UserID" },
                values: new object[] { new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9567), 23.714285714285714285714285714m, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 40, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9570), 58.428571428571428571428571429m, 3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateTime", "Price", "UserID" },
                values: new object[] { new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9572), 32.714285714285714285714285714m, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 1, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9575), 22.285714285714285714285714286m, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 45, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9578), 38.714285714285714285714285714m, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "DateTime", "Price", "UserID" },
                values: new object[] { 16, new DateTime(2025, 1, 11, 19, 43, 18, 355, DateTimeKind.Local).AddTicks(9580), 68.857142857142857142857142857m, 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Nickname", "Password", "Photo", "School" },
                values: new object[,]
                {
                    { 1, "user1@gmail.com", "user1", "zaq1@WSX", "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png", "Śl.TZN" },
                    { 2, "user2@gmail.com", "user2", "zaq1@WSX", "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png", "Śl.TZN" },
                    { 3, "user3@gmail.com", "user3", "zaq1@WSX", "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png", "Śl.TZN" },
                    { 4, "user4@gmail.com", "user4", "zaq1@WSX", "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png", "Śl.TZN" },
                    { 5, "user5@gmail.com", "user5", "zaq1@WSX", "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png", "Śl.TZN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_UserID",
                table: "Items",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
