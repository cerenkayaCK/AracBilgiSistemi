using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstOrnek.Migrations
{
    /// <inheritdoc />
    public partial class DorduncuGoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SahipId",
                table: "Arabalar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sahip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sahip", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_SahipId",
                table: "Arabalar",
                column: "SahipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arabalar_Sahip_SahipId",
                table: "Arabalar",
                column: "SahipId",
                principalTable: "Sahip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arabalar_Sahip_SahipId",
                table: "Arabalar");

            migrationBuilder.DropTable(
                name: "Sahip");

            migrationBuilder.DropIndex(
                name: "IX_Arabalar_SahipId",
                table: "Arabalar");

            migrationBuilder.DropColumn(
                name: "SahipId",
                table: "Arabalar");
        }
    }
}
