using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstOrnek.Migrations
{
    /// <inheritdoc />
    public partial class ILK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arabalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KatEttigiMesafe = table.Column<float>(type: "real", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arabalar", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arabalar");
        }
    }
}
