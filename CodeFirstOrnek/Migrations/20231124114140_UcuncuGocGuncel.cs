using Microsoft.EntityFrameworkCore.Migrations;



#nullable disable

namespace CodeFirstOrnek.Migrations
{
    /// <inheritdoc />
    public partial class UcuncuGocGuncel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlakaKod",
                table: "Plakalar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlakaKod",
                table: "Plakalar");
        }
    }
}
