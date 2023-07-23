using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fullstack.Api.Migrations
{
    public partial class ProductsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatagoryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<int>(type: "int", nullable: false),
                    ProductCode = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    varientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CostPrice = table.Column<double>(type: "float", nullable: false),
                    Stock = table.Column<double>(type: "float", nullable: false),
                    TotalParches = table.Column<double>(type: "float", nullable: false),
                    LastParchesDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastParchesSupplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSales = table.Column<double>(type: "float", nullable: false),
                    LastSalesDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastSalesCustomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
