﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pandacommercedal.Migrations
{
    /// <inheritdoc />
    public partial class productandproductcategoryrelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryCategoryID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryCategoryID",
                table: "Products",
                column: "ProductCategoryCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_productCategories_ProductCategoryCategoryID",
                table: "Products",
                column: "ProductCategoryCategoryID",
                principalTable: "productCategories",
                principalColumn: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_productCategories_ProductCategoryCategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCategoryCategoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductCategoryCategoryID",
                table: "Products");
        }
    }
}