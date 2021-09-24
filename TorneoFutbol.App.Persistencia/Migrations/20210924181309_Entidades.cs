using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoFutbol.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arbitros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colegio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DesempeñoEquip",
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
                    table.PrimaryKey("PK_DesempeñoEquip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectoresTecnicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoresTecnicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
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
                    table.PrimaryKey("PK_Estadios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estadios_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipoLocal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarcadorInicial = table.Column<int>(type: "int", nullable: false),
                    EquipoVisitante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarcadorFinal = table.Column<int>(type: "int", nullable: false),
                    Colegio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArbitroId = table.Column<int>(type: "int", nullable: true),
                    ReporteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partido_Arbitros_ArbitroId",
                        column: x => x.ArbitroId,
                        principalTable: "Arbitros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "equipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioId = table.Column<int>(type: "int", nullable: true),
                    DesempeñoEquiposId = table.Column<int>(type: "int", nullable: true),
                    PartidosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_equipo_DesempeñoEquip_DesempeñoEquiposId",
                        column: x => x.DesempeñoEquiposId,
                        principalTable: "DesempeñoEquip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_equipo_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_equipo_Partido_PartidosId",
                        column: x => x.PartidosId,
                        principalTable: "Partido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jugadore",
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
                    table.PrimaryKey("PK_Jugadore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jugadore_equipo_equiposId",
                        column: x => x.equiposId,
                        principalTable: "equipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Gol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinutoGol = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JugadoresId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gol_Jugadore_JugadoresId",
                        column: x => x.JugadoresId,
                        principalTable: "Jugadore",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reportes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPartido = table.Column<int>(type: "int", nullable: false),
                    MarcadorFinal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarjetasAmarillas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarjetasRojas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GolesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reportes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reportes_Gol_GolesId",
                        column: x => x.GolesId,
                        principalTable: "Gol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_equipo_DesempeñoEquiposId",
                table: "equipo",
                column: "DesempeñoEquiposId");

            migrationBuilder.CreateIndex(
                name: "IX_equipo_MunicipioId",
                table: "equipo",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_equipo_PartidosId",
                table: "equipo",
                column: "PartidosId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_MunicipioId",
                table: "Estadios",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Gol_JugadoresId",
                table: "Gol",
                column: "JugadoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadore_equiposId",
                table: "Jugadore",
                column: "equiposId");

            migrationBuilder.CreateIndex(
                name: "IX_Partido_ArbitroId",
                table: "Partido",
                column: "ArbitroId");

            migrationBuilder.CreateIndex(
                name: "IX_Partido_ReporteId",
                table: "Partido",
                column: "ReporteId");

            migrationBuilder.CreateIndex(
                name: "IX_Reportes_GolesId",
                table: "Reportes",
                column: "GolesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Partido_Reportes_ReporteId",
                table: "Partido",
                column: "ReporteId",
                principalTable: "Reportes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_equipo_DesempeñoEquip_DesempeñoEquiposId",
                table: "equipo");

            migrationBuilder.DropForeignKey(
                name: "FK_equipo_Municipios_MunicipioId",
                table: "equipo");

            migrationBuilder.DropForeignKey(
                name: "FK_equipo_Partido_PartidosId",
                table: "equipo");

            migrationBuilder.DropTable(
                name: "DirectoresTecnicos");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
                name: "DesempeñoEquip");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Partido");

            migrationBuilder.DropTable(
                name: "Arbitros");

            migrationBuilder.DropTable(
                name: "Reportes");

            migrationBuilder.DropTable(
                name: "Gol");

            migrationBuilder.DropTable(
                name: "Jugadore");

            migrationBuilder.DropTable(
                name: "equipo");
        }
    }
}
