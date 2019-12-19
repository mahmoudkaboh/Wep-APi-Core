using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WepApiCore.Migrations
{
    public partial class changeTBLNameToInvoices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productDetails");

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Item = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Unitprice = table.Column<decimal>(nullable: true),
                    Total = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.CreateTable(
                name: "productDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Item = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(nullable: true),
                    Unitprice = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productDetails", x => x.ID);
                });
        }
    }
}
