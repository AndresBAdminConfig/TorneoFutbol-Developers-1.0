using System;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;
namespace TorneoFutbol.App.Consola
{
    class Program
    {
        private static IRepositorioEstadio _repoEstadio =  new RepositorioEstadio();                
        private static IRepositorioReporte _repoReporte =  new RepositorioReporte();
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioGoles _repoGoles = new RepositorioGoles();
        private static IRepositorioArbitros _repoArbitros = new RepositorioArbitros();
        private static IRepositorioPartidos _repoPartidos = new RepositorioPartidos();
        private static IRepositorioDirectorTecnico _repoDirectorTecnico = new RepositorioDirectorTecnico();
        private static IRepositorioDesempeñoEquipo _repoDesempeñoEquipo = new RepositorioDesempeñoEquipo();


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddEstadio();
            //DeleteEstadio();
            //IndexEstadios();
            //AddReporte();
            //DeleteReporte();
            //IndexReportes();
            //AddJugadores();
            //DeleteJugador();
            //IndexJugador();
            //AddMunicipio();
            //DeleteMunicipio();
            //IndexMunicipio();
            //AddPartidos();
            //IndexPartido();
            //DeletePartidos();
            //AddDesempeñoEquipos();
            //IndexDesempeñoEquipos();
            //DeleteDesempeñoEquipos();
            //Goles
            AddGoles();
            //IndexGoles();
            //DeleteGoles();
            //Arbitros
            //AddArbitros();
            //IndexArbitros();
            //DeleteArbitros();
            //DirectorTecnico
            //AddDirectorTecnico();
            //IndexDirectorTecnico();
            //DeleteDirectorTecnico();
        }

        private static void AddEstadio()
        {
            var estadio = new Estadio
            {
                Nombre = "Atanasio Girardot",
                Direccion = "Carrera 74#48010"
            };
            _repoEstadio.AddEstadio(estadio);
        }
        private static void IndexEstadios()
        {
            foreach (var estadio in _repoEstadio.GetAllEstadios())
            {
                Console.WriteLine(estadio.Nombre + " " + estadio.Direccion );
            }
        }
        private static void DeleteEstadio()
        {
            _repoEstadio.DeleteEstadio(2);
        }
        private static void AddReporte()
        {
            var Reportes = new Reporte
            {
                MarcadorFinal = "1 - 1",
                TarjetasAmarillas = "0",
                TarjetasRojas = "0"
            };
            _repoReporte.AddReporte(Reportes);
        } 

        private static void IndexReportes()
        {
            foreach (var Reportes in _repoReporte.GetAllReportes())
            {
                Console.WriteLine(Reportes.MarcadorFinal + " " +"Tarjetas amarillas:"+ Reportes.TarjetasAmarillas+" "+"Tarejtas Rojas"+Reportes.TarjetasRojas );
            }
        }
        private static void DeleteReporte()
        {
            _repoReporte.DeleteReporte(2);
        }


        private static void AddJugadores()
        {
            var jugadores = new Jugador
            {
                Nombre = "Pepito",
                Numero = "09",
                Posicion = "Delantero",
            };
            _repoJugador.AddJugadores(jugadores);
        }
        private static void IndexJugador()
        {
            foreach (var jugadores in _repoJugador.GetAllJugador())
            {
                Console.WriteLine(jugadores.Nombre + " " + jugadores.Numero + " " + jugadores.Posicion);
            }
        }
        private static void DeleteJugador()
        {
            _repoJugador.DeleteJugador(2);
        }
        private static void AddMunicipio()
        {
            var municipio = new Municipio
            {
                Nombre = "Manizales",
                
            };
            _repoMunicipio.AddMunicipio(municipio);
        }
        private static void IndexMunicipio()
        {
            foreach (var municipio in _repoMunicipio.GetAllMunicipio())
            {
                Console.WriteLine(municipio.Nombre );
            }
        }
        private static void DeleteMunicipio()
        {
            _repoMunicipio.DeleteMunicipio(2);
        }
        private static void AddPartidos()
        {
            var Partido = new Partido 
            {
                FechaHora = "29/09/2021 17:20",
                EquipoLocal = "equipo uno",
                MarcadorInicial = "0-0",
                EquipoVisitante = "equipo2",
                MarcadorFinal = " 1-1 ",
                Colegio = "Normal Superior"
            };
            _repoPartidos.AddPartidos(Partido);
        }
        private static void IndexPartido()
        {
            foreach (var Partido in _repoPartidos.GetAllPartidos())

            {
                Console.WriteLine(Partido.Id );
            }
        }
        private static void DeletePartidos()
        {
            _repoPartidos.DeletePartidos(2); 
        }
        
        private static void AddDesempeñoEquipos()
        {
            var DesempeñoEquipos = new DesempeñoEquipo
            {
                Cantidad_Partidos_Jugados = 5,
                Cantidad_Partidos_Ganados = 2,
                Cantidad_Partidos_Empatados = 1,
                GF = 3,
                GC = 1,
                Puntos = 10
            };
            _repoDesempeñoEquipo.AddDesempeñoEquipos(DesempeñoEquipos);
        }
        private static void IndexDesempeñoEquipos ()
        {
            foreach (var DesempeñoEquipos in _repoDesempeñoEquipo.GetAllDesempeñoEquipo())
            {
                Console.WriteLine(DesempeñoEquipos.Id);
            }
        }
        private static void DeleteDesempeñoEquipos()
        {
            _repoDesempeñoEquipo.DeleteDesempeñoEquipos(2); 
        }
        //Program Goles
        private static void AddGoles()
        {
            var Gol = new Gol
            {
                MinutoGol = new DateTime(1974, 7, 10, 7, 10, 24)  
            };
            _repoGoles.AddGoles(Gol);
        }
        
        private static void IndexGoles()
        {
            foreach (var Gol in _repoGoles.GetAllGoles())
            {
                Console.WriteLine(Gol.MinutoGol);
            }
        }
        private static void DeleteGoles()
        {
            _repoGoles.DeleteGoles(2);
        }
        //Program Arbitros
        private static void AddArbitros()
        {
            var Arbitro = new Arbitro
            {
                Nombre = "Samuel",
                Documento = "987258",
                Telefono = "3021654",
                Colegio = "Normal Superior Sol"
            };
            _repoArbitros.AddArbitros(arbitro);
        }
        
        private static void IndexArbitros()
        {
            foreach (var arbitro in _repoArbitros.GetAllArbitros())
            {
                Console.WriteLine(arbitro.Nombre + " " + arbitro.Documento + " " + arbitro.Telefono + " " + arbitro.Colegio);
            }
        }
        private static void DeleteArbitros()
        {
            _repoArbitros.DeleteArbitros(2);
        }
        //Director Técnico
        private static void AddDirectorTecnico()
        {
            var DirectorTecnico = new DirectorTecnico
            {
                Nombre = "Juanito",
                Documento = "17990",
                Telefono = "302202"
            };
            _repoDirectorTecnico.AddDirectorTecnico(DirectorTecnico);
        }
        
        private static void IndexDirectorTecnico()
        {
            foreach (var DirectorTecnico in _repoDirectorTecnico.GetAllDirectorTecnico())
            {
                Console.WriteLine(DirectorTecnico.Nombre + " " + DirectorTecnico.Documento + " " + DirectorTecnico.Telefono);
            }
        }
        private static void DeleteDirectorTecnico()
        {
            _repoDirectorTecnico.DeleteDirectorTecnico(2);
        }
    }
}
