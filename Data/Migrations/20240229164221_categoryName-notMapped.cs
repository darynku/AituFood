using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AituFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class categoryNamenotMapped : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Product",
                newName: "CompanyName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Product",
                newName: "CategoryName");
        }
    }
}
