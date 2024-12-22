using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Infrastructure.Data.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class _111111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ShebaNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasePrice = table.Column<int>(type: "int", nullable: false),
                    HighestPrice = table.Column<int>(type: "int", nullable: false),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false),
                    OpeningTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ClosingTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    HasWinner = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    WinnerCustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bids", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesMan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    Wage = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ShebaNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sealer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ShebaNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    BidId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Bids_BidId",
                        column: x => x.BidId,
                        principalTable: "Bids",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategory_Category",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Booth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Medal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booth", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booth_SalesMan_Id",
                        column: x => x.Id,
                        principalTable: "SalesMan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SumOfPrice = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factors_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Price = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    FactorId = table.Column<int>(type: "int", nullable: true),
                    BoothId = table.Column<int>(type: "int", nullable: false),
                    BidId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Bids_BidId",
                        column: x => x.BidId,
                        principalTable: "Bids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Booth",
                        column: x => x.BoothId,
                        principalTable: "Booth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Factors_FactorId",
                        column: x => x.FactorId,
                        principalTable: "Factors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_SubCategory",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Customer",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_Product",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerHistory_Customer",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerHistory_Product",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FactorProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactorID = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactorProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FactorProduct_Factors_FactorID",
                        column: x => x.FactorID,
                        principalTable: "Factors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactorProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bids",
                columns: new[] { "Id", "BasePrice", "ClosingTime", "HasWinner", "HighestPrice", "IsOpen", "OpeningTime", "ProductId", "WinnerCustomerId" },
                values: new object[,]
                {
                    { 1, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 2, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 3, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 4, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null },
                    { 5, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null },
                    { 6, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null },
                    { 7, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, null },
                    { 8, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, null },
                    { 9, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, null },
                    { 10, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, null },
                    { 11, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, null },
                    { 12, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, null },
                    { 13, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, null },
                    { 14, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, null },
                    { 15, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, null },
                    { 16, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, null },
                    { 17, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, null },
                    { 18, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, null },
                    { 19, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, null },
                    { 20, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, null },
                    { 21, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, null },
                    { 22, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, null },
                    { 23, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, null },
                    { 24, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, null },
                    { 25, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, null },
                    { 26, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, null },
                    { 27, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, null },
                    { 28, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, null },
                    { 29, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, null },
                    { 30, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, null },
                    { 31, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, null },
                    { 32, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, null },
                    { 33, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, null },
                    { 34, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, null },
                    { 35, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, null },
                    { 36, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, null },
                    { 37, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, null },
                    { 38, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, null },
                    { 39, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, null },
                    { 40, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, null },
                    { 41, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, null },
                    { 42, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, null },
                    { 43, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, null },
                    { 44, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, null },
                    { 45, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, null },
                    { 46, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, null },
                    { 47, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, null },
                    { 48, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, null },
                    { 49, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, null },
                    { 50, 1113733, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1113733, false, new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, null }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, null, "Games" },
                    { 2, null, "Jewelery" },
                    { 3, null, "Health" },
                    { 4, null, "Industrial" },
                    { 5, null, "Beauty" },
                    { 6, null, "Health" },
                    { 7, null, "Clothing" },
                    { 8, null, "Baby" },
                    { 9, null, "Computers" },
                    { 10, null, "Games" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "BidId", "BirthDate", "CardNumber", "Email", "FirstName", "IsDeleted", "LastName", "PhoneNumber", "RegisterDate", "ShebaNumber", "UserName" },
                values: new object[,]
                {
                    { 1, "Gerlachfurt", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Twila.Runolfsson24@yahoo.com", "Lavinia", false, "Kunde", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emmett_Bailey" },
                    { 2, "Bergnaummouth", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Danny_Heidenreich@hotmail.com", "Keara", false, "Kozey", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thurman.Beahan41" },
                    { 3, "Erikastad", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tressie_Cummerata58@hotmail.com", "Janice", false, "Johnston", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Walter53" },
                    { 4, "New Whitneyville", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kathleen78@yahoo.com", "Tania", false, "Schaefer", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Darron.Grant75" },
                    { 5, "North Shawnmouth", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Davonte_Conroy75@gmail.com", "Nayeli", false, "Thiel", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dariana27" },
                    { 6, "Robertsmouth", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jordi.Rath14@gmail.com", "Garth", false, "Morissette", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hubert.Stamm" },
                    { 7, "North June", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lottie.Muller5@yahoo.com", "Devonte", false, "Dickens", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Philip.Veum89" },
                    { 8, "Lake Adriennebury", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Orpha_Gibson72@gmail.com", "Johnnie", false, "Schneider", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hal.Jenkins" },
                    { 9, "West Evelynton", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Felipe80@gmail.com", "Gregg", false, "Haley", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Doris12" },
                    { 10, "Valentinchester", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Baby1@gmail.com", "Aletha", false, "Quitzon", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eliezer.Vandervort" },
                    { 11, "Anastasiaside", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Coty38@hotmail.com", "Cary", false, "Hirthe", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Osvaldo_Monahan" },
                    { 12, "East Joeyberg", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Susie_Welch6@gmail.com", "Idella", false, "Kessler", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sydnie_Hilll68" },
                    { 13, "North Jules", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Raquel81@yahoo.com", "Jarred", false, "Fadel", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lynn.Hand" },
                    { 14, "Lake Travon", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mozelle14@yahoo.com", "Melvina", false, "Hintz", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gunner.Okuneva" },
                    { 15, "Emiliobury", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hailey.Mills29@yahoo.com", "Loraine", false, "Pacocha", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Juliana.Williamson90" },
                    { 16, "Naderville", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marcella_Hermiston@yahoo.com", "Santina", false, "Roberts", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sarai_Johnston66" },
                    { 17, "Thompsonville", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Akeem96@yahoo.com", "Clement", false, "Deckow", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mariana_Davis85" },
                    { 18, "Greenfeldermouth", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Haylie0@yahoo.com", "Rudolph", false, "Bradtke", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Haskell40" },
                    { 19, "West Rossfort", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lilian_Hilpert@gmail.com", "Heather", false, "Cummings", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Humberto_Ryan" },
                    { 20, "Norrischester", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Erick_Borer@yahoo.com", "Makayla", false, "Murazik", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sabrina_Pacocha" },
                    { 21, "Lake Albertaburgh", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Clarissa92@hotmail.com", "Broderick", false, "Von", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Retta_Mante44" },
                    { 22, "Heidenreichburgh", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elian92@gmail.com", "Bridget", false, "Adams", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nelda41" },
                    { 23, "Kertzmannport", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Imogene35@hotmail.com", "Luther", false, "Zboncak", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jaquelin47" },
                    { 24, "Odamouth", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ola39@yahoo.com", "Gay", false, "McClure", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dolly78" },
                    { 25, "Kattiechester", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elna49@hotmail.com", "Otho", false, "Rau", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marie_Mohr" },
                    { 26, "Terryland", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pietro_Cremin@gmail.com", "Gladyce", false, "Kutch", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dewitt_Langosh92" },
                    { 27, "Bernierland", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kevon53@hotmail.com", "Ephraim", false, "Larson", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Johanna66" },
                    { 28, "Tedport", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Shemar.Torphy60@yahoo.com", "Tyshawn", false, "Goodwin", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nicholaus.Feeney" },
                    { 29, "Port Josefa", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Winona3@hotmail.com", "Ansel", false, "Wilderman", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vinnie12" },
                    { 30, "Kesslerstad", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ozella49@hotmail.com", "Dante", false, "King", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Teagan85" },
                    { 31, "Port Stone", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kevin.Tremblay14@gmail.com", "Nyah", false, "Mitchell", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lia.Bode67" },
                    { 32, "New Marlene", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nikolas64@gmail.com", "Lizeth", false, "Torp", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hayden.Hills" },
                    { 33, "Aufderharside", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vada_Langosh89@hotmail.com", "Flavie", false, "Hilll", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marty23" },
                    { 34, "Mayerside", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Genevieve.Bernhard41@yahoo.com", "Antonietta", false, "Rath", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Laney_Terry" },
                    { 35, "South Julio", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Violet.Bernhard67@gmail.com", "Gregorio", false, "Huel", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Melyna_Torp" },
                    { 36, "Mrazville", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hailey74@gmail.com", "Noelia", false, "Johnston", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cassie.Schumm" },
                    { 37, "Rogahnport", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Claire.Zemlak@yahoo.com", "Nels", false, "Schuster", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rossie.Hintz" },
                    { 38, "Port Josh", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dena56@gmail.com", "Connor", false, "Feil", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Warren_Fisher20" },
                    { 39, "Hildachester", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ellis7@yahoo.com", "Rossie", false, "Schmidt", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kaya.Pouros85" },
                    { 40, "Kenyonfort", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jett99@gmail.com", "Haven", false, "Pacocha", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lela95" },
                    { 41, "Ortizview", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Annamae35@hotmail.com", "Darien", false, "Bahringer", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Briana.Konopelski68" },
                    { 42, "West Leopoldo", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vincenza_Schumm78@yahoo.com", "Philip", false, "Koepp", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lourdes_Mraz" },
                    { 43, "Lemuelstad", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lessie0@hotmail.com", "Noah", false, "Mosciski", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Easton76" },
                    { 44, "Beierborough", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Foster18@yahoo.com", "Erika", false, "Stark", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Aniyah34" },
                    { 45, "Shannyhaven", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Krystina_Bernier@gmail.com", "Marley", false, "Brekke", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fernando.Homenick" },
                    { 46, "Jacobimouth", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jerrod6@hotmail.com", "Mylene", false, "Hartmann", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Keaton.Bednar49" },
                    { 47, "Lake Orville", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Toy15@hotmail.com", "Dusty", false, "Hermiston", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elva_Prohaska" },
                    { 48, "Veronaland", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bradley_Tromp75@yahoo.com", "Melyna", false, "Schmeler", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fannie_Koepp74" },
                    { 49, "Rathshire", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eda.VonRueden93@hotmail.com", "Frank", false, "Koepp", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Riley_Beahan28" },
                    { 50, "Russelville", null, new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Patricia41@hotmail.com", "Nedra", false, "Cormier", null, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pamela_Metz22" }
                });

            migrationBuilder.InsertData(
                table: "SalesMan",
                columns: new[] { "Id", "Address", "BirthDate", "CardNumber", "Email", "FirstName", "IsDeleted", "LastName", "PhoneNumber", "RegisterDate", "ShebaNumber", "UserName", "Wage" },
                values: new object[,]
                {
                    { 1, "Landenside", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eduardo_Bartoletti57@yahoo.com", "Christop", false, "Wisoky", "53197067370", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Palma_Bartell", 0 },
                    { 2, "Grahamburgh", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rosalinda_Nader@gmail.com", "Triston", false, "Schamberger", "40199348288", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rosina64", 0 },
                    { 3, "Jonesview", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Idella_OConner43@gmail.com", "Anthony", false, "Schoen", "19157762305", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Citlalli_Marks", 0 },
                    { 4, "Burdetteland", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lee_Wiegand27@yahoo.com", "Lorenz", false, "Schoen", "16503214147", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Faye95", 0 },
                    { 5, "Efrainstad", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Adella.Funk@gmail.com", "Brionna", false, "Bechtelar", "67885027450", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vernice43", 0 },
                    { 6, "Letitiaview", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sister_Yundt64@hotmail.com", "Deion", false, "MacGyver", "85311329753", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vern8", 0 },
                    { 7, "West Micah", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ida.Bahringer75@hotmail.com", "Ines", false, "Ward", "02477939173", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marisol41", 0 },
                    { 8, "Lake Gordonberg", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mellie.Nolan38@yahoo.com", "Georgianna", false, "Hermiston", "70945594295", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sam36", 0 },
                    { 9, "Carleyhaven", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alexie.Hagenes@yahoo.com", "Mellie", false, "Hahn", "68136653229", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nakia.Marquardt", 0 },
                    { 10, "Hoegerhaven", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brent_Watsica@hotmail.com", "Gunnar", false, "Tremblay", "18040682813", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Imogene_Howell87", 0 },
                    { 11, "East Rettaside", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Trinity_Howe47@hotmail.com", "Kade", false, "King", "74961974628", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cedrick_Witting58", 0 },
                    { 12, "North Stacy", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hershel15@gmail.com", "Alexzander", false, "Gusikowski", "73497541178", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "King99", 0 },
                    { 13, "Kayceeburgh", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Peggie_Nikolaus81@yahoo.com", "Manley", false, "Heller", "36440350230", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silas_Daugherty", 0 },
                    { 14, "Mabellechester", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magdalen.Heathcote@yahoo.com", "Oren", false, "Bergnaum", "22369672917", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Melody88", 0 },
                    { 15, "East Miguel", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Linwood.Berge8@gmail.com", "Lauriane", false, "Thiel", "45736280701", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bertha30", 0 },
                    { 16, "Jaydonport", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kamren97@yahoo.com", "Earnest", false, "Keebler", "03261318225", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mackenzie.Cole5", 0 },
                    { 17, "Rosenbaumberg", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alberta_Rogahn0@yahoo.com", "Savion", false, "McClure", "10907072581", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Teagan_Lindgren45", 0 },
                    { 18, "East Peggie", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jarrod_Kreiger@yahoo.com", "Erwin", false, "Kris", "26553462308", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Antone64", 0 },
                    { 19, "Clevebury", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jerod95@hotmail.com", "Jarod", false, "Runte", "88246530441", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dino_Hilll67", 0 },
                    { 20, "Kerlukeborough", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ayden.OHara11@hotmail.com", "Jovan", false, "Monahan", "78331343689", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Garrett.Crist", 0 },
                    { 21, "Casandraborough", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Filiberto59@gmail.com", "Thea", false, "Denesik", "36807142585", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Erna_Barrows", 0 },
                    { 22, "Mohrmouth", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brock_Gleason62@hotmail.com", "Rahul", false, "Gleason", "36936277752", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rodrick_Rowe49", 0 },
                    { 23, "Hannaside", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Norene59@hotmail.com", "Lionel", false, "Volkman", "54165639505", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Josephine.Homenick", 0 },
                    { 24, "Port Shanonhaven", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Angeline_Streich88@gmail.com", "Hilbert", false, "Koelpin", "16953671851", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kelsi_Bogisich90", 0 },
                    { 25, "Port Lesliefort", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mckayla_Collier77@gmail.com", "Alfonzo", false, "Kris", "63328972365", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alysa45", 0 },
                    { 26, "East Clara", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kristoffer_Schuppe@gmail.com", "Lavina", false, "Streich", "41978881743", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hardy_Tremblay2", 0 },
                    { 27, "Gersonland", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Janie_Smitham79@yahoo.com", "Mariah", false, "Kuhn", "06374333048", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Giles.Ward49", 0 },
                    { 28, "Timmyshire", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Abdul_Lindgren96@yahoo.com", "Joe", false, "Cassin", "10860000743", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bridgette61", 0 },
                    { 29, "South Hayley", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Daniela.Yost@yahoo.com", "Sincere", false, "Torp", "36110161423", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kyra.Adams", 0 },
                    { 30, "O'Keefeborough", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kyleigh_Bogisich41@yahoo.com", "Otho", false, "Mertz", "51448033749", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Garrett73", 0 },
                    { 31, "Violetborough", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lance.Romaguera@gmail.com", "Newton", false, "Lockman", "89787544654", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jamison.Roob", 0 },
                    { 32, "North Savannah", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mylene_Ritchie11@yahoo.com", "Ethel", false, "Dach", "31329374015", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brannon_Pagac", 0 },
                    { 33, "West Luzton", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Guy1@yahoo.com", "Jamey", false, "Hansen", "93950179622", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Wilhelm82", 0 },
                    { 34, "Whiteside", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jaylen75@hotmail.com", "Vivienne", false, "MacGyver", "07069002097", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elissa_Fahey", 0 },
                    { 35, "West Dejaton", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Aryanna_Deckow10@yahoo.com", "Pierre", false, "Kozey", "96329723108", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Germaine15", 0 },
                    { 36, "New Leliamouth", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cyril_Green7@hotmail.com", "Carlotta", false, "Mosciski", "19526804970", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ashleigh.Dicki29", 0 },
                    { 37, "South Clement", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Austen75@yahoo.com", "Nelle", false, "Mills", "68190721256", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gerard.Hegmann41", 0 },
                    { 38, "Smithamtown", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Katelin_Bednar@hotmail.com", "Lavina", false, "Feil", "40974454036", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Richie11", 0 },
                    { 39, "West Quintenton", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Samanta.Rutherford@gmail.com", "Dejah", false, "Hettinger", "60410174057", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Isaac96", 0 },
                    { 40, "East Susannaborough", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Toy5@gmail.com", "Anastasia", false, "Turcotte", "86862558302", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Harvey.Schoen99", 0 },
                    { 41, "Kovacekchester", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tamara_Crona@gmail.com", "Pedro", false, "Jaskolski", "57605370982", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Johnpaul68", 0 },
                    { 42, "East Kamrynside", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alexandra59@yahoo.com", "Raegan", false, "Yundt", "46236761298", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Missouri.Wintheiser", 0 },
                    { 43, "North Jonas", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hettie.Frami94@gmail.com", "Frances", false, "Emmerich", "50456441746", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Waino.Kozey", 0 },
                    { 44, "East Mireille", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Yolanda63@hotmail.com", "Peyton", false, "Dare", "61310627108", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Newton.Wolf42", 0 },
                    { 45, "Isaactown", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Armand_Nitzsche26@yahoo.com", "Ofelia", false, "Jenkins", "89581140837", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bianka_Vandervort", 0 },
                    { 46, "West Viviane", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Austyn60@hotmail.com", "Angelita", false, "Halvorson", "07325555772", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frida31", 0 },
                    { 47, "Lake Enochfort", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jamal.Ledner@yahoo.com", "Napoleon", false, "Wyman", "79534725203", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cathrine_Terry", 0 },
                    { 48, "North Tyson", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kiel.Hansen@hotmail.com", "Daren", false, "Bosco", "23062728591", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Melisa.Effertz4", 0 },
                    { 49, "West Joshuaport", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hosea.Keeling80@yahoo.com", "Nova", false, "Boyer", "06190850114", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Troy.Jaskolski55", 0 },
                    { 50, "Bradtkebury", new DateTime(1985, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Veda42@gmail.com", "Damion", false, "Gibson", "26696899214", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Valentine87", 0 }
                });

            migrationBuilder.InsertData(
                table: "Booth",
                columns: new[] { "Id", "Description", "ImageUrl", "Medal", "Name" },
                values: new object[,]
                {
                    { 1, "Unde dolorum occaecati est.", null, 1, "excepturi" },
                    { 2, "Aut non blanditiis voluptas numquam tempore consectetur et.", null, 1, "nihil" },
                    { 3, "In ea provident.", null, 2, "aliquid" },
                    { 4, "Dolores odio sunt quis aut.", null, 1, "non" },
                    { 5, "Minima sequi non dolores consequatur.", null, 2, "aliquid" },
                    { 6, "Consequatur error eum maiores sed qui aliquid.", null, 1, "ut" },
                    { 7, "Quis voluptatibus neque voluptatem cumque in sunt numquam rerum non.", null, 2, "veniam" },
                    { 8, "Voluptates aut alias.", null, 2, "exercitationem" },
                    { 9, "Corporis amet est magni rerum ex delectus qui.", null, 1, "sint" },
                    { 10, "Dicta consequatur dicta illo suscipit.", null, 1, "aut" },
                    { 11, "Qui hic voluptate sequi.", null, 0, "dolorem" },
                    { 12, "Impedit totam et aut sed rerum fugiat et.", null, 2, "eaque" },
                    { 13, "At minima quibusdam id iusto perspiciatis aut quia.", null, 2, "assumenda" },
                    { 14, "Ipsa in qui fugiat.", null, 2, "nulla" },
                    { 15, "Eveniet aperiam et sunt modi est et eius.", null, 1, "veritatis" },
                    { 16, "Aliquam aspernatur odit quis expedita occaecati.", null, 2, "eveniet" },
                    { 17, "Excepturi eos ipsa dolor velit illum et nihil.", null, 1, "sit" },
                    { 18, "Vitae assumenda adipisci beatae minus.", null, 0, "voluptatem" },
                    { 19, "Ratione ut eius.", null, 2, "omnis" },
                    { 20, "Officia placeat aut facere sint non rerum rem ut velit.", null, 0, "numquam" },
                    { 21, "Saepe ea voluptatem architecto officiis excepturi provident ut.", null, 1, "doloribus" },
                    { 22, "Iste voluptatum possimus.", null, 2, "ut" },
                    { 23, "Exercitationem reiciendis eum necessitatibus est quasi.", null, 1, "sit" },
                    { 24, "Earum quam est nihil repellat ipsa.", null, 2, "libero" },
                    { 25, "Et repellat nesciunt nisi quis soluta perspiciatis aut nulla.", null, 0, "praesentium" },
                    { 26, "Qui fugit nostrum et ut veritatis.", null, 0, "velit" },
                    { 27, "Sit facere voluptate dignissimos similique.", null, 0, "eum" },
                    { 28, "Et maiores vel.", null, 0, "quod" },
                    { 29, "Amet quia hic id.", null, 0, "rerum" },
                    { 30, "Tempora quia totam maiores corrupti nemo ipsam.", null, 1, "nisi" },
                    { 31, "Culpa harum officia voluptatem dolore facere ut aut sunt aut.", null, 0, "explicabo" },
                    { 32, "Iure molestiae similique.", null, 2, "itaque" },
                    { 33, "Tenetur blanditiis perferendis atque est odit et.", null, 2, "odit" },
                    { 34, "Et nihil quas.", null, 2, "praesentium" },
                    { 35, "Eum ullam eos itaque.", null, 1, "consequatur" },
                    { 36, "In ut totam quis incidunt vitae iste et autem.", null, 0, "ab" },
                    { 37, "Cupiditate similique ratione illum.", null, 0, "sit" },
                    { 38, "Dignissimos est assumenda vel sed consequuntur vitae sequi quae.", null, 0, "vel" },
                    { 39, "Ut et expedita iusto.", null, 2, "architecto" },
                    { 40, "Velit at ut nesciunt molestiae numquam atque libero deleniti.", null, 1, "corporis" },
                    { 41, "Facilis consequuntur possimus id beatae consequatur.", null, 0, "ut" },
                    { 42, "Voluptatem molestiae excepturi et.", null, 0, "recusandae" },
                    { 43, "Labore accusamus dolores.", null, 0, "quae" },
                    { 44, "Et a perspiciatis error nisi dolorem.", null, 0, "excepturi" },
                    { 45, "Quos consequatur temporibus molestiae ipsa numquam ullam.", null, 1, "praesentium" },
                    { 46, "Quis distinctio ab non iure quas quia dolorem iusto.", null, 1, "fuga" },
                    { 47, "Doloremque ut magnam molestias quibusdam veritatis excepturi.", null, 1, "laborum" },
                    { 48, "Cumque unde iusto nihil et officiis consequatur quo itaque nostrum.", null, 1, "repellat" },
                    { 49, "Minus error doloremque sequi.", null, 0, "quam" },
                    { 50, "Dolorum accusantium doloribus sapiente omnis illum dolor provident esse ut.", null, 0, "eius" }
                });

            migrationBuilder.InsertData(
                table: "SubCategory",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 5, null, null, "repudiandae" },
                    { 2, 7, null, null, "tenetur" },
                    { 3, 6, null, null, "sit" },
                    { 4, 6, null, null, "et" },
                    { 5, 1, null, null, "reprehenderit" },
                    { 6, 2, null, null, "deleniti" },
                    { 7, 4, null, null, "fugit" },
                    { 8, 10, null, null, "quisquam" },
                    { 9, 8, null, null, "ex" },
                    { 10, 9, null, null, "est" },
                    { 11, 7, null, null, "eveniet" },
                    { 12, 4, null, null, "et" },
                    { 13, 5, null, null, "omnis" },
                    { 14, 2, null, null, "voluptate" },
                    { 15, 3, null, null, "commodi" },
                    { 16, 8, null, null, "ut" },
                    { 17, 9, null, null, "doloremque" },
                    { 18, 8, null, null, "delectus" },
                    { 19, 7, null, null, "repellat" },
                    { 20, 3, null, null, "fugiat" },
                    { 21, 9, null, null, "exercitationem" },
                    { 22, 7, null, null, "magnam" },
                    { 23, 8, null, null, "quia" },
                    { 24, 6, null, null, "quo" },
                    { 25, 1, null, null, "et" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BidId", "BoothId", "Description", "FactorId", "ImageUrl", "IsConfirmed", "IsDeleted", "Name", "Price", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, 1, 1, "Ea sed aliquid repellat iste voluptatum. Neque distinctio ipsum perferendis fuga fugit voluptatem. Officia ut velit quidem quia ratione saepe. Ipsa et ab repudiandae ea aut sunt non sapiente. Quasi quo animi et voluptas asperiores doloribus.", null, null, false, false, "Intelligent Steel Car", "671.92", 1 },
                    { 2, 2, 2, "Natus reprehenderit qui repudiandae at tempore velit quos quaerat. Qui enim et molestias natus ratione. Sunt facilis illo. Ipsa iusto reiciendis. Molestias esse facilis ducimus.", null, null, false, false, "Sleek Cotton Car", "640.04", 2 },
                    { 3, 3, 3, "Cupiditate aut adipisci ut at unde. Consequatur dolore voluptatem. Laboriosam atque et. Praesentium quibusdam quam cum est sint tenetur. Possimus ut aliquam assumenda ipsa dolorum.", null, null, false, false, "Sleek Metal Gloves", "942.23", 3 },
                    { 4, 4, 4, "Dolores at suscipit. Molestias molestiae ut consectetur dolorem eaque dolorem recusandae numquam. Sit est enim harum sit ut sunt deserunt odio necessitatibus.", null, null, false, false, "Handmade Steel Cheese", "598.24", 4 },
                    { 5, 5, 5, "Sed qui laudantium qui reprehenderit id. Et ipsum et veniam voluptas officia. Dolor quia iste sed odio numquam corrupti consequatur. Ab laudantium ut esse dignissimos adipisci qui eos.", null, null, false, false, "Licensed Steel Mouse", "43.47", 5 },
                    { 6, 6, 6, "Illum provident in voluptatem facilis laudantium. Est aut consequatur quisquam. Ad modi earum facere sunt ut facere pariatur. Non pariatur consectetur sit iusto dignissimos. Et debitis sequi et deserunt at id officia eos tenetur.", null, null, false, false, "Unbranded Cotton Sausages", "845.48", 6 },
                    { 7, 7, 7, "Eligendi minus sint quas et nostrum quibusdam. Dolorem id inventore necessitatibus soluta eum dolore. Voluptatem ad ducimus non. Et sed nihil corrupti aliquid necessitatibus eos inventore pariatur. Ab enim ipsam et quis.", null, null, false, false, "Unbranded Granite Pants", "515.73", 7 },
                    { 8, 8, 8, "Quidem vero quibusdam pariatur et deleniti nihil. Aut dolore sint qui est est laborum dolores. Similique in distinctio.", null, null, false, false, "Unbranded Steel Sausages", "476.14", 8 },
                    { 9, 9, 9, "Rerum a optio vitae aliquam. Nulla tempora quis quaerat fuga rerum. Velit et nihil delectus beatae dolores. Et est tempore sit molestiae qui unde. Ratione ipsam ducimus autem incidunt ut.", null, null, false, false, "Incredible Cotton Chair", "592.06", 9 },
                    { 10, 10, 10, "Aut praesentium corrupti ex officiis autem. Doloribus incidunt illo. Suscipit accusamus architecto quod neque. Cum nesciunt et rerum nihil. Ut vel fugiat. Et qui soluta deleniti neque vitae.", null, null, false, false, "Handmade Frozen Bacon", "714.36", 10 },
                    { 11, 11, 11, "Unde sit natus consectetur. Delectus aut et. Quibusdam et praesentium voluptatem. Consectetur voluptatum blanditiis vel occaecati ut eaque delectus.", null, null, false, false, "Handcrafted Wooden Bike", "214.08", 11 },
                    { 12, 12, 12, "Nesciunt esse in et ut. Est rem eum ut maiores consequatur cumque. Aliquam aut iure modi eius occaecati saepe labore sed repellendus.", null, null, false, false, "Rustic Rubber Towels", "718.77", 12 },
                    { 13, 13, 13, "Facilis occaecati est eos voluptas id. Molestias quos minus aperiam. Sunt modi reprehenderit sint quo consequuntur quo aut.", null, null, false, false, "Licensed Wooden Towels", "780.92", 13 },
                    { 14, 14, 14, "Numquam temporibus sed consectetur nihil accusantium ex asperiores officia totam. Voluptas voluptatem sint rerum. Minus atque atque quia voluptatem reiciendis qui sed earum voluptatibus. Perferendis est voluptatem dolorem aut quas nulla occaecati iusto.", null, null, false, false, "Incredible Plastic Chicken", "303.26", 14 },
                    { 15, 15, 15, "Quidem molestiae quis. Reiciendis adipisci eius eveniet deserunt officiis amet dolor assumenda labore. Alias magnam odio sequi laboriosam eum. Corporis consequuntur suscipit corporis repellat.", null, null, false, false, "Incredible Plastic Chair", "451.53", 15 },
                    { 16, 16, 16, "Illo nisi totam sint earum alias cum quibusdam quo. Exercitationem repudiandae quia beatae veniam ipsa ullam ab. Vero accusantium impedit commodi fuga nesciunt distinctio tempore velit. Voluptatem neque cumque porro consequatur quo eveniet molestiae vitae.", null, null, false, false, "Awesome Cotton Mouse", "308.74", 16 },
                    { 17, 17, 17, "Aut non perferendis modi porro velit minima. Corporis et repellendus ut reiciendis nulla. Minima voluptas deleniti doloremque reprehenderit error deserunt velit tenetur. Eum fugit eius quod et. Deleniti aperiam qui et hic est.", null, null, false, false, "Practical Granite Towels", "451.49", 17 },
                    { 18, 18, 18, "Aspernatur culpa commodi et vitae quia. Odit asperiores excepturi. Reiciendis esse aut inventore vero. Exercitationem veritatis quidem accusamus labore. Enim sequi incidunt consequatur harum. Repellat tempore aliquid repellendus adipisci aut autem alias laudantium aperiam.", null, null, false, false, "Sleek Plastic Chair", "892.19", 18 },
                    { 19, 19, 19, "Nulla velit itaque deserunt mollitia voluptatem veritatis voluptatibus qui. Eos ad ab voluptas at sint qui. Asperiores voluptas recusandae adipisci. Voluptates nobis at et. Ipsum molestiae perspiciatis at suscipit. Enim doloremque officiis eaque veniam pariatur laborum.", null, null, false, false, "Handmade Plastic Shirt", "369.77", 19 },
                    { 20, 20, 20, "Cumque sit autem voluptatem explicabo iure consequuntur illum et voluptatibus. Voluptates quod veniam. Vel eius voluptatibus consequatur itaque quos qui qui rerum.", null, null, false, false, "Generic Metal Bike", "359.02", 20 },
                    { 21, 21, 21, "Unde nam qui ut dolorem vitae autem. Ducimus laudantium non maxime distinctio quae nulla. Perspiciatis error vel iste. Nobis ut nesciunt praesentium dolore ea. A voluptatem et ut aliquam aut et commodi.", null, null, false, false, "Tasty Wooden Bike", "323.26", 21 },
                    { 22, 22, 22, "Provident ut qui placeat autem omnis quibusdam. Ea culpa esse consequatur. Et et molestiae dignissimos.", null, null, false, false, "Refined Wooden Fish", "920.77", 22 },
                    { 23, 23, 23, "Enim quos iste laborum. Aut nihil ducimus aspernatur sed consequatur. Eligendi molestiae quo qui. Itaque qui placeat distinctio atque dolore aut.", null, null, false, false, "Handmade Steel Tuna", "569.84", 23 },
                    { 24, 24, 24, "Delectus delectus incidunt voluptatem quam aliquam labore neque ipsam quam. Dolores ipsam totam ipsam quo id alias qui. Eos sed sint omnis error dolorem.", null, null, false, false, "Unbranded Fresh Shirt", "245.10", 24 },
                    { 25, 25, 25, "Magnam aut sunt nulla et. Consequatur blanditiis numquam nihil dolorum nemo. Non ipsum omnis. Vero adipisci saepe nam est at nulla ab. Facere mollitia perferendis et sed assumenda molestias eum. Non eveniet rem temporibus ea repellat ad aliquam porro dolores.", null, null, false, false, "Awesome Steel Towels", "607.35", 25 },
                    { 26, 26, 26, "Amet aliquid voluptatem est cupiditate magnam est autem labore dolorum. Dignissimos natus corporis at et libero. A debitis amet et quo eveniet iure rem. Ut dignissimos dolor porro.", null, null, false, false, "Sleek Steel Tuna", "944.40", 1 },
                    { 27, 27, 27, "Minus ex sapiente ipsum cum omnis. Officia eum optio velit facilis aut quo reprehenderit. Officia quod sed sint consequuntur quaerat illo aut. Aliquid veritatis et laudantium ut fugiat.", null, null, false, false, "Awesome Soft Sausages", "374.69", 2 },
                    { 28, 28, 28, "Impedit molestias sint aspernatur nemo iste est est nihil quidem. Quia dolore tenetur maiores vel. Commodi rem corporis pariatur autem voluptas corrupti fugiat consequuntur non. Eaque quia quos et odit cumque debitis incidunt animi.", null, null, false, false, "Practical Plastic Sausages", "417.99", 3 },
                    { 29, 29, 29, "Porro quisquam culpa numquam rerum nulla natus sed. Praesentium maiores ratione sint sit doloremque voluptatem sit et voluptates. Dolores qui iusto eius unde architecto possimus non. Perspiciatis assumenda voluptatem praesentium sed est.", null, null, false, false, "Licensed Metal Ball", "765.16", 4 },
                    { 30, 30, 30, "Tempore ut dignissimos sed omnis sapiente. Sunt sequi quidem. Consequatur cumque quia.", null, null, false, false, "Gorgeous Frozen Chips", "571.90", 5 },
                    { 31, 31, 31, "Aliquid ab voluptate. Sapiente nobis quibusdam sunt voluptatem aut enim rerum. Non dolorem animi doloribus aspernatur repellat fugit impedit quidem sit. Optio expedita omnis rerum eaque deleniti saepe dolore sed recusandae. Dolorum dolores possimus. Accusamus dolorem voluptatum nemo.", null, null, false, false, "Gorgeous Plastic Tuna", "145.52", 6 },
                    { 32, 32, 32, "Ut exercitationem quaerat libero facere. Porro quisquam quas asperiores nemo molestiae. Sed repellendus fugit voluptatem cupiditate a dicta sed totam. Earum consequuntur rerum ut.", null, null, false, false, "Fantastic Cotton Shoes", "328.65", 7 },
                    { 33, 33, 33, "Deserunt quasi amet harum culpa. Omnis voluptate ut et voluptas. Rerum ipsam earum cupiditate doloremque ut voluptates occaecati voluptate.", null, null, false, false, "Intelligent Granite Ball", "151.72", 8 },
                    { 34, 34, 34, "Ratione iure sed delectus minus magni expedita quaerat laudantium. Deleniti dignissimos nesciunt voluptate cum ullam quo. Explicabo sit harum nostrum aut sequi. Ut distinctio vero odio. Consequuntur ipsam eaque iste voluptate voluptatem consequatur.", null, null, false, false, "Sleek Steel Gloves", "663.69", 9 },
                    { 35, 35, 35, "Molestiae unde et facere aut minus. Nam deserunt modi ex quia at qui vel omnis. Rem quibusdam illum eveniet voluptatum neque.", null, null, false, false, "Small Metal Ball", "404.44", 10 },
                    { 36, 36, 36, "Iusto autem eveniet in. Debitis est veniam mollitia unde consequuntur deserunt ut provident. Nobis vel omnis. Maiores rerum est dolore corrupti ut. Qui eum et ratione aut beatae sint. Sequi nulla praesentium mollitia aperiam nihil.", null, null, false, false, "Generic Steel Tuna", "771.72", 11 },
                    { 37, 37, 37, "Asperiores earum quasi quisquam. Ducimus numquam rerum quis. Magni velit nisi labore molestiae modi repellendus ducimus odio. Tempore velit vel. Tempora repellendus sint minus numquam.", null, null, false, false, "Sleek Soft Sausages", "393.18", 12 },
                    { 38, 38, 38, "Excepturi ipsam dolor molestiae distinctio et ut. Consequatur quo quae aliquam. Ad unde impedit suscipit atque fuga iste qui natus.", null, null, false, false, "Refined Plastic Bacon", "816.52", 13 },
                    { 39, 39, 39, "Eveniet molestiae consequatur mollitia suscipit expedita sint voluptates. Cupiditate omnis sit. Non perferendis ut dolor non quisquam praesentium libero. Non quo consectetur qui repellat hic et veniam.", null, null, false, false, "Sleek Cotton Sausages", "488.46", 14 },
                    { 40, 40, 40, "Et qui et dolores ea quidem. Vel impedit odio pariatur quis perspiciatis minima voluptatem. Non voluptatem et non in ut voluptate aut distinctio delectus. Quisquam aperiam ab et totam et.", null, null, false, false, "Handmade Cotton Bike", "574.91", 15 },
                    { 41, 41, 41, "Doloremque voluptatibus quo. Placeat id et ea. Delectus culpa occaecati commodi. Explicabo ipsa recusandae ipsa. Voluptatum reprehenderit tempora.", null, null, false, false, "Generic Soft Soap", "980.65", 16 },
                    { 42, 42, 42, "Ut facilis officia ullam fuga et. Incidunt nobis quo. Ad doloremque natus amet possimus blanditiis non odio. Vel provident optio nobis similique.", null, null, false, false, "Licensed Metal Tuna", "109.64", 17 },
                    { 43, 43, 43, "Odit modi neque iusto in autem. Eveniet odio dolores eos ex. Eum voluptas ducimus. Eaque modi voluptatem magni sed dicta et iusto rerum. Qui sint non ut incidunt maxime consequatur omnis illo et. Laborum vel quia harum.", null, null, false, false, "Handmade Soft Chair", "997.55", 18 },
                    { 44, 44, 44, "Et distinctio aut omnis omnis. Nisi et eos excepturi repellat harum rem. Vel incidunt ut harum est minus eum. Culpa cumque molestiae voluptas ratione dolores quia et. Quaerat nisi animi non at voluptas rem qui.", null, null, false, false, "Rustic Frozen Mouse", "130.24", 19 },
                    { 45, 45, 45, "Reiciendis voluptates dolorum magnam. Quaerat ipsam similique accusamus rem sunt vitae sit suscipit. Rem nulla optio numquam consequatur id nostrum accusamus fuga non. Et sit deleniti impedit sit autem modi similique qui recusandae.", null, null, false, false, "Small Metal Sausages", "524.82", 20 },
                    { 46, 46, 46, "Voluptatum magni quo assumenda ratione dolores sint expedita. Hic nihil unde qui. Eaque repellat est et eum dolores sunt nesciunt. Ullam vero laborum aut alias.", null, null, false, false, "Gorgeous Cotton Tuna", "946.51", 21 },
                    { 47, 47, 47, "Illum quod temporibus. Possimus exercitationem nam qui sed incidunt sunt cum quia. Saepe cupiditate occaecati sunt quo aliquam animi ipsam voluptas. Voluptates provident magnam sint quo sunt eligendi.", null, null, false, false, "Generic Concrete Towels", "154.45", 22 },
                    { 48, 48, 48, "Delectus odit provident totam. Fuga inventore non sit iusto. Odit quam vitae. Quo ipsum ducimus et eveniet magnam pariatur modi.", null, null, false, false, "Rustic Plastic Pizza", "44.44", 23 },
                    { 49, 49, 49, "Omnis eum necessitatibus deserunt ipsam iste totam corporis repellendus sit. Repellendus voluptas qui explicabo magni voluptate nostrum quos. Odio tenetur ut. Ea a fugit aut corrupti. Nesciunt nam sint ad et.", null, null, false, false, "Rustic Wooden Chips", "609.15", 24 },
                    { 50, 50, 50, "Voluptate eum fugit vel. Molestiae quia magni. Quod illum rem sed dolores mollitia non occaecati consectetur ex. Qui illum laudantium quia voluptatem ut. Aspernatur corrupti ut.", null, null, false, false, "Intelligent Granite Computer", "894.45", 25 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CustomerId", "IsConfirmed", "IsDeleted", "Message", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, false, false, "Quaerat dolor sint dolore delectus illo voluptates nam fugit.", 1 },
                    { 2, 2, false, false, "Sit dolorum eligendi in non fuga ea.", 2 },
                    { 3, 3, false, false, "Doloribus officia nulla molestiae.", 3 },
                    { 4, 4, false, false, "Fugit molestiae recusandae deserunt velit esse quia.", 4 },
                    { 5, 5, false, false, "Voluptas qui natus laborum repellendus ullam eum.", 5 },
                    { 6, 6, false, false, "Mollitia pariatur sequi et consequatur deleniti provident et repellat.", 6 },
                    { 7, 7, false, false, "Doloribus quisquam recusandae qui dolorum et.", 7 },
                    { 8, 8, false, false, "Cum ea voluptatem doloremque praesentium.", 8 },
                    { 9, 9, false, false, "Magnam autem maiores quos dolorem dolores.", 9 },
                    { 10, 10, false, false, "Maxime quia sit nihil reprehenderit id est vero eligendi harum.", 10 },
                    { 11, 11, false, false, "Et deserunt voluptatem molestiae animi nobis.", 11 },
                    { 12, 12, false, false, "Fugiat rerum minima odit saepe et.", 12 },
                    { 13, 13, false, false, "Dolores ex et ad qui maiores commodi ullam.", 13 },
                    { 14, 14, false, false, "Est nam nihil.", 14 },
                    { 15, 15, false, false, "Inventore rerum incidunt voluptatum maiores est et.", 15 },
                    { 16, 16, false, false, "Et voluptatum qui consectetur corporis aut suscipit.", 16 },
                    { 17, 17, false, false, "Nobis rerum et hic cum aliquam.", 17 },
                    { 18, 18, false, false, "Repellendus qui officiis facilis doloremque velit.", 18 },
                    { 19, 19, false, false, "Autem voluptas saepe dolor sit rerum voluptate.", 19 },
                    { 20, 20, false, false, "Quia quia qui numquam ut debitis vitae vitae sint.", 20 },
                    { 21, 21, false, false, "Doloremque aut ex aut ut facere eum et quas dignissimos.", 21 },
                    { 22, 22, false, false, "Aut consequuntur necessitatibus sit enim aut inventore exercitationem consequuntur est.", 22 },
                    { 23, 23, false, false, "Vitae aut sint nemo consequatur laudantium.", 23 },
                    { 24, 24, false, false, "Quas cumque et ex omnis alias reprehenderit sed commodi non.", 24 },
                    { 25, 25, false, false, "Ut non dignissimos delectus.", 25 },
                    { 26, 26, false, false, "Aut repellat magnam rerum a omnis accusantium repellendus reprehenderit aut.", 26 },
                    { 27, 27, false, false, "Est rem quos molestiae rerum consequatur vel repellat.", 27 },
                    { 28, 28, false, false, "Qui possimus commodi necessitatibus itaque odit id non.", 28 },
                    { 29, 29, false, false, "Omnis et earum sed.", 29 },
                    { 30, 30, false, false, "Molestias enim iste in doloremque est cum quo sapiente est.", 30 },
                    { 31, 31, false, false, "Libero minus officiis animi adipisci.", 31 },
                    { 32, 32, false, false, "Porro ducimus eius excepturi aliquam harum commodi hic at ipsa.", 32 },
                    { 33, 33, false, false, "Et et et cumque id dolores.", 33 },
                    { 34, 34, false, false, "Et reprehenderit temporibus repellendus enim et nobis autem porro non.", 34 },
                    { 35, 35, false, false, "Autem eos molestiae sapiente autem.", 35 },
                    { 36, 36, false, false, "Dolores eveniet laudantium magnam cum consectetur et.", 36 },
                    { 37, 37, false, false, "Nobis dolor vitae ut.", 37 },
                    { 38, 38, false, false, "Expedita et ut necessitatibus maiores et adipisci non quia.", 38 },
                    { 39, 39, false, false, "Eum laudantium sint fugiat.", 39 },
                    { 40, 40, false, false, "Voluptatum dolor similique libero qui suscipit quia nihil.", 40 },
                    { 41, 41, false, false, "Minus itaque velit.", 41 },
                    { 42, 42, false, false, "Id qui necessitatibus animi.", 42 },
                    { 43, 43, false, false, "Non officiis sed eos ut earum.", 43 },
                    { 44, 44, false, false, "Mollitia mollitia voluptatem maxime.", 44 },
                    { 45, 45, false, false, "Temporibus omnis ea hic cumque quas est esse.", 45 },
                    { 46, 46, false, false, "Ducimus ducimus commodi sed nesciunt quae animi.", 46 },
                    { 47, 47, false, false, "Voluptas officia voluptatem.", 47 },
                    { 48, 48, false, false, "Sit maiores sapiente deleniti.", 48 },
                    { 49, 49, false, false, "Non et quas modi id.", 49 },
                    { 50, 50, false, false, "A qui earum dolor voluptas non et vitae minima amet.", 50 }
                });

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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CustomerId",
                table: "Comments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_BidId",
                table: "Customer",
                column: "BidId",
                unique: true,
                filter: "[BidId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerHistory_CustomerId",
                table: "CustomerHistory",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerHistory_ProductId",
                table: "CustomerHistory",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_FactorProduct_FactorID",
                table: "FactorProduct",
                column: "FactorID");

            migrationBuilder.CreateIndex(
                name: "IX_FactorProduct_ProductId",
                table: "FactorProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Factors_CustomerId",
                table: "Factors",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_BidId",
                table: "Product",
                column: "BidId",
                unique: true,
                filter: "[BidId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BoothId",
                table: "Product",
                column: "BoothId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_FactorId",
                table: "Product",
                column: "FactorId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubCategoryId",
                table: "Product",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CustomerHistory");

            migrationBuilder.DropTable(
                name: "FactorProduct");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Booth");

            migrationBuilder.DropTable(
                name: "Factors");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "SalesMan");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Bids");
        }
    }
}
