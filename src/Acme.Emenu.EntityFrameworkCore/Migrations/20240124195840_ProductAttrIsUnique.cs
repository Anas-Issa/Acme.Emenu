using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.Emenu.Migrations
{
    /// <inheritdoc />
    public partial class ProductAttrIsUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductAttributes_ProductId",
                table: "ProductAttributes");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_ProductId_AttributeTypeId",
                table: "ProductAttributes",
                columns: new[] { "ProductId", "AttributeTypeId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductAttributes_ProductId_AttributeTypeId",
                table: "ProductAttributes");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_ProductId",
                table: "ProductAttributes",
                column: "ProductId");
        }
    }
}
