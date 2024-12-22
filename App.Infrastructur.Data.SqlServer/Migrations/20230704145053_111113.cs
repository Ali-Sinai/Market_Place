using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructure.Data.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class _111113 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactorProduct_Factors_FactorID",
                table: "FactorProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_FactorProduct_Product_ProductId",
                table: "FactorProduct");

            migrationBuilder.AddForeignKey(
                name: "FK_FactorProduct_Factor",
                table: "FactorProduct",
                column: "FactorID",
                principalTable: "Factors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FactorProduct_Product",
                table: "FactorProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactorProduct_Factor",
                table: "FactorProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_FactorProduct_Product",
                table: "FactorProduct");

            migrationBuilder.AddForeignKey(
                name: "FK_FactorProduct_Factors_FactorID",
                table: "FactorProduct",
                column: "FactorID",
                principalTable: "Factors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactorProduct_Product_ProductId",
                table: "FactorProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
