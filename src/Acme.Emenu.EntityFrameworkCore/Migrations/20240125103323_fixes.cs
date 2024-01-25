using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.Emenu.Migrations
{
    /// <inheritdoc />
    public partial class fixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AttributeOptions_AttributeTypeId",
                table: "AttributeOptions");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AttributeTypes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "AttributeOptions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeTypes_Name",
                table: "AttributeTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttributeOptions_AttributeTypeId_Value",
                table: "AttributeOptions",
                columns: new[] { "AttributeTypeId", "Value" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AttributeTypes_Name",
                table: "AttributeTypes");

            migrationBuilder.DropIndex(
                name: "IX_AttributeOptions_AttributeTypeId_Value",
                table: "AttributeOptions");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AttributeTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "AttributeOptions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeOptions_AttributeTypeId",
                table: "AttributeOptions",
                column: "AttributeTypeId");
        }
    }
}
