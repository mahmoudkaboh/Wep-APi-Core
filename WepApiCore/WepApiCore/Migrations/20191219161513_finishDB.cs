using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WepApiCore.Migrations
{
    public partial class finishDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Products",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Invoices",
                newName: "InvoiceID");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Invoices",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceProduct",
                columns: table => new
                {
                    InvoiceProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InvoiceID = table.Column<int>(nullable: true),
                    ProductID = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceProduct", x => x.InvoiceProductID);
                    table.ForeignKey(
                        name: "FK_InvoiceProduct_Invoices_InvoiceID",
                        column: x => x.InvoiceID,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceProduct_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerID",
                table: "Invoices",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceProduct_InvoiceID",
                table: "InvoiceProduct",
                column: "InvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceProduct_ProductID",
                table: "InvoiceProduct",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Customer_CustomerID",
                table: "Invoices",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Customer_CustomerID",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "InvoiceProduct");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_CustomerID",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Products",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "InvoiceID",
                table: "Invoices",
                newName: "ID");
        }
    }
}
