using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstOrnek.Migrations
{
    /// <inheritdoc />
    public partial class ikinciGoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arabalar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Arabalar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Arabalar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Arabalar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Arabalar",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Arabalar",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Arabalar",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Arabalar",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AddColumn<int>(
                name: "PlakaId",
                table: "Arabalar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Plakalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plakalar", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_PlakaId",
                table: "Arabalar",
                column: "PlakaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Arabalar_Plakalar_PlakaId",
                table: "Arabalar",
                column: "PlakaId",
                principalTable: "Plakalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arabalar_Plakalar_PlakaId",
                table: "Arabalar");

            migrationBuilder.DropTable(
                name: "Plakalar");

            migrationBuilder.DropIndex(
                name: "IX_Arabalar_PlakaId",
                table: "Arabalar");

            migrationBuilder.DropColumn(
                name: "PlakaId",
                table: "Arabalar");

            migrationBuilder.InsertData(
                table: "Arabalar",
                columns: new[] { "Id", "KatEttigiMesafe", "Marka", "Model", "Renk" },
                values: new object[,]
                {
                    { 1, 10000f, "Toyota", "Corolla", "Siyah" },
                    { 2, 8000f, "Honda", "Civic", "Beyaz" },
                    { 3, 12000f, "Ford", "Focus", "Mavi" },
                    { 4, 15000f, "Volkswagen", "Golf", "Kırmızı" },
                    { 5, 9000f, "Renault", "Megane", "Gri" },
                    { 6, 11000f, "Chevrolet", "Cruze", "Sarı" },
                    { 7, 13000f, "Hyundai", "Elantra", "Yeşil" },
                    { 8, 10000f, "Nissan", "Altima", "Turuncu" }
                });
        }
    }
}
