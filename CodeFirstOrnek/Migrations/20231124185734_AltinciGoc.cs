using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstOrnek.Migrations
{
    /// <inheritdoc />
    public partial class AltinciGoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arabalar_Sahip_SahipId",
                table: "Arabalar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sahip",
                table: "Sahip");

            migrationBuilder.RenameTable(
                name: "Sahip",
                newName: "Sahipler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sahipler",
                table: "Sahipler",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Arabalar_Sahipler_SahipId",
                table: "Arabalar",
                column: "SahipId",
                principalTable: "Sahipler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arabalar_Sahipler_SahipId",
                table: "Arabalar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sahipler",
                table: "Sahipler");

            migrationBuilder.RenameTable(
                name: "Sahipler",
                newName: "Sahip");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sahip",
                table: "Sahip",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Arabalar_Sahip_SahipId",
                table: "Arabalar",
                column: "SahipId",
                principalTable: "Sahip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
