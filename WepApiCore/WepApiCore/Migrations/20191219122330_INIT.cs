using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WepApiCore.Migrations
{
    public partial class INIT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productDetails",
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
                    table.PrimaryKey("PK_productDetails", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productDetails");
        }
    }
}
