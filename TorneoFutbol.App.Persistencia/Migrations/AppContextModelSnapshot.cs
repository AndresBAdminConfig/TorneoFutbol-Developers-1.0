﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Arbitro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Colegio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Arbitros");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.DesempeñoEquipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cantidad_Partidos_Empatados")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad_Partidos_Ganados")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad_Partidos_Jugados")
                        .HasColumnType("int");

                    b.Property<int>("GC")
                        .HasColumnType("int");

                    b.Property<int>("GF")
                        .HasColumnType("int");

                    b.Property<int>("Puntos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DesempeñoEquipos");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.DirectorTecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DirectoresTecnicos");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DesempeñoequiposId")
                        .HasColumnType("int");

                    b.Property<int?>("MunicipiosId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DesempeñoequiposId");

                    b.HasIndex("MunicipiosId");

                    b.HasIndex("PartidoId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Estadio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MunicipiosId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MunicipiosId");

                    b.ToTable("Estadios");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Gol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("JugadoresId")
                        .HasColumnType("int");

                    b.Property<string>("MinutoGol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReporteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JugadoresId");

                    b.HasIndex("ReporteId");

                    b.ToTable("Goles");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EquiposId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Posicion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquiposId");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ArbitrosId")
                        .HasColumnType("int");

                    b.Property<string>("Colegio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipoLocal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipoVisitante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaHora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarcadorFinal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarcadorInicial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArbitrosId");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Reporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MarcadorFinal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartidosId")
                        .HasColumnType("int");

                    b.Property<string>("TarjetasAmarillas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarjetasRojas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PartidosId");

                    b.ToTable("Reportes");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Equipo", b =>
                {
                    b.HasOne("TorneoFutbol.App.Dominio.DesempeñoEquipo", "Desempeñoequipos")
                        .WithMany()
                        .HasForeignKey("DesempeñoequiposId");

                    b.HasOne("TorneoFutbol.App.Dominio.Municipio", "Municipios")
                        .WithMany("Equipos")
                        .HasForeignKey("MunicipiosId");

                    b.HasOne("TorneoFutbol.App.Dominio.Partido", null)
                        .WithMany("Equipos")
                        .HasForeignKey("PartidoId");

                    b.Navigation("Desempeñoequipos");

                    b.Navigation("Municipios");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Estadio", b =>
                {
                    b.HasOne("TorneoFutbol.App.Dominio.Municipio", "Municipios")
                        .WithMany("Estadios")
                        .HasForeignKey("MunicipiosId");

                    b.Navigation("Municipios");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Gol", b =>
                {
                    b.HasOne("TorneoFutbol.App.Dominio.Jugador", "Jugadores")
                        .WithMany()
                        .HasForeignKey("JugadoresId");

                    b.HasOne("TorneoFutbol.App.Dominio.Reporte", null)
                        .WithMany("Goles")
                        .HasForeignKey("ReporteId");

                    b.Navigation("Jugadores");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Jugador", b =>
                {
                    b.HasOne("TorneoFutbol.App.Dominio.Equipo", "Equipos")
                        .WithMany("Jugadores")
                        .HasForeignKey("EquiposId");

                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Partido", b =>
                {
                    b.HasOne("TorneoFutbol.App.Dominio.Arbitro", "Arbitros")
                        .WithMany()
                        .HasForeignKey("ArbitrosId");

                    b.Navigation("Arbitros");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Reporte", b =>
                {
                    b.HasOne("TorneoFutbol.App.Dominio.Partido", "Partidos")
                        .WithMany()
                        .HasForeignKey("PartidosId");

                    b.Navigation("Partidos");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Equipo", b =>
                {
                    b.Navigation("Jugadores");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Municipio", b =>
                {
                    b.Navigation("Equipos");

                    b.Navigation("Estadios");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Partido", b =>
                {
                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("TorneoFutbol.App.Dominio.Reporte", b =>
                {
                    b.Navigation("Goles");
                });
#pragma warning restore 612, 618
        }
    }
}
