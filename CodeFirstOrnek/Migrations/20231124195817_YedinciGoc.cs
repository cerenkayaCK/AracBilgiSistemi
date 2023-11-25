using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstOrnek.Migrations
{
    /// <inheritdoc />
    public partial class YedinciGoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TamAd",
                table: "Sahipler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TamAd",
                table: "Sahipler");
        }
    }
}
