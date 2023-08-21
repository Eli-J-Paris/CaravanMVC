using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaravanMVC.Migrations
{
    /// <inheritdoc />
    public partial class WagonIsCovered : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_coverd",
                table: "wagons",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_coverd",
                table: "wagons");
        }
    }
}
