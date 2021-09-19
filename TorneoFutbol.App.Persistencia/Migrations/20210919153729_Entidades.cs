using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoFutbol.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DesempeñoEquipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad_Partidos_Jugados = table.Column<int>(type: "int", nullable: false),
                    Cantidad_Partidos_Ganados = table.Column<int>(type: "int", nullable: false),
                    Cantidad_Partidos_Empatados = table.Column<int>(type: "int", nullable: false),
                    GF = table.Column<int>(type: "int", nullable: false),
                    GC = table.Column<int>(type: "int", nullable: false),
                    Puntos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesempeñoEquipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioId = table.Column<int>(type: "int", nullable: true),
                    DesempeñoEquiposId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_equipos_DesempeñoEquipos_DesempeñoEquiposId",
                        column: x => x.DesempeñoEquiposId,
                        principalTable: "DesempeñoEquipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_equipos_Municipio_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estadio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estadio_Municipio_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Posicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    equiposId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jugadores_equipos_equiposId",
                        column: x => x.equiposId,
                        principalTable: "equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_equipos_DesempeñoEquiposId",
                table: "equipos",
                column: "DesempeñoEquiposId");

            migrationBuilder.CreateIndex(
                name: "IX_equipos_MunicipioId",
                table: "equipos",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadio_MunicipioId",
                table: "Estadio",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_equiposId",
                table: "Jugadores",
                column: "equiposId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estadio");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "equipos");

            migrationBuilder.DropTable(
                name: "DesempeñoEquipos");

            migrationBuilder.DropTable(
                name: "Municipio");
        }
    }
}
