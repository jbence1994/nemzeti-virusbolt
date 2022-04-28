using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace NemzetiVirusbolt.Api.Persistence.Migrations
{
    public partial class AddMerchantsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "merchant_id",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "merchants",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_merchants", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_merchant_id",
                table: "products",
                column: "merchant_id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_merchants_merchant_id",
                table: "products",
                column: "merchant_id",
                principalTable: "merchants",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_merchants_merchant_id",
                table: "products");

            migrationBuilder.DropTable(
                name: "merchants");

            migrationBuilder.DropIndex(
                name: "IX_products_merchant_id",
                table: "products");

            migrationBuilder.DropColumn(
                name: "merchant_id",
                table: "products");
        }
    }
}
