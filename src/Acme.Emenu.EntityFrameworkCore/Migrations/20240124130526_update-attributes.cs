using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.Emenu.Migrations
{
    /// <inheritdoc />
    public partial class updateattributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeTypes_AppProducts_ProductId",
                table: "AttributeTypes");

            migrationBuilder.DropIndex(
                name: "IX_AttributeTypes_ProductId",
                table: "AttributeTypes");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "AttributeTypes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "AttributeTypes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttributeTypes_ProductId",
                table: "AttributeTypes",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeTypes_AppProducts_ProductId",
                table: "AttributeTypes",
                column: "ProductId",
                principalTable: "AppProducts",
                principalColumn: "Id");
        }
    }
}
