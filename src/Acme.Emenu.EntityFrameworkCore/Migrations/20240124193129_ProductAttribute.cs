using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.Emenu.Migrations
{
    /// <inheritdoc />
    public partial class ProductAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeOptions_AttributeOptions_AttributeOptionId",
                table: "AttributeOptions");

            migrationBuilder.DropIndex(
                name: "IX_AttributeOptions_AttributeOptionId",
                table: "AttributeOptions");

            migrationBuilder.DropColumn(
                name: "AttributeOptionId",
                table: "AttributeOptions");

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AttributeTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_AppProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "AppProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_AttributeTypes_AttributeTypeId",
                        column: x => x.AttributeTypeId,
                        principalTable: "AttributeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_AttributeTypeId",
                table: "ProductAttributes",
                column: "AttributeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_ProductId",
                table: "ProductAttributes",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAttributes");

            migrationBuilder.AddColumn<int>(
                name: "AttributeOptionId",
                table: "AttributeOptions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttributeOptions_AttributeOptionId",
                table: "AttributeOptions",
                column: "AttributeOptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeOptions_AttributeOptions_AttributeOptionId",
                table: "AttributeOptions",
                column: "AttributeOptionId",
                principalTable: "AttributeOptions",
                principalColumn: "Id");
        }
    }
}
