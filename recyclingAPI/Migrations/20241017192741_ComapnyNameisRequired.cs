using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace recyclingAPI.Migrations
{
    /// <inheritdoc />
    public partial class ComapnyNameisRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "siema");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Companies");
        }
    }
}
