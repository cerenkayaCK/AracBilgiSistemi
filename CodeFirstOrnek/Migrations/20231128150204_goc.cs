using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstOrnek.Migrations
{
    /// <inheritdoc />
    public partial class goc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Muhendisler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muhendisler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plakalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlakaKod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plakalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sahipler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TamAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sahipler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arabalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KatEttigiMesafe = table.Column<float>(type: "real", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlakaId = table.Column<int>(type: "int", nullable: false),
                    SahipId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arabalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arabalar_Plakalar_PlakaId",
                        column: x => x.PlakaId,
                        principalTable: "Plakalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arabalar_Sahipler_SahipId",
                        column: x => x.SahipId,
                        principalTable: "Sahipler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArabaMuhendis",
                columns: table => new
                {
                    ArabalarId = table.Column<int>(type: "int", nullable: false),
                    MuhendisListesiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaMuhendis", x => new { x.ArabalarId, x.MuhendisListesiId });
                    table.ForeignKey(
                        name: "FK_ArabaMuhendis_Arabalar_ArabalarId",
                        column: x => x.ArabalarId,
                        principalTable: "Arabalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArabaMuhendis_Muhendisler_MuhendisListesiId",
                        column: x => x.MuhendisListesiId,
                        principalTable: "Muhendisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_PlakaId",
                table: "Arabalar",
                column: "PlakaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_SahipId",
                table: "Arabalar",
                column: "SahipId");

            migrationBuilder.CreateIndex(
                name: "IX_ArabaMuhendis_MuhendisListesiId",
                table: "ArabaMuhendis",
                column: "MuhendisListesiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArabaMuhendis");

            migrationBuilder.DropTable(
                name: "Arabalar");

            migrationBuilder.DropTable(
                name: "Muhendisler");

            migrationBuilder.DropTable(
                name: "Plakalar");

            migrationBuilder.DropTable(
                name: "Sahipler");
        }
    }
}
