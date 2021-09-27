using System;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;
namespace TorneoFutbol.App.Consola
{
    class Program
    {
        private static IRepositorioEstadios _repoEstadio =  new RepositorioEstadios(new Persistencia.AppContext());                
        private static IRepositorioReporte _repoReporte =  new RepositorioReporte(new Persistencia.AppContext());
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioGoles _repoGoles = new RepositorioGoles();
        private static IRepositorioArbitros _repoArbitros = new RepositorioArbitros();

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
            AddMunicipio();
            //DeleteMunicipio();
            //IndexMunicipio();
            AddPartidos();
            IndexPartido();
            DeletePartidos();
            AddDesempeñoEquipos();
            IndexDesempeñoEquipos();
            DeleteDesempeñoEquipos();
            //Goles
            AddGoles();
            IndexGoles();
            DeleteGoles();
            //Arbitros
            AddArbitros();
            IndexArbitros();
            DeleteArbitros();
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
            var reporte = new Reporte
            {
                MarcadorFinal = "0 - 2",
                TarjetasAmarillas = "2",
                TarjetasRojas = "0"
            };
            _repoReporte.AddReporte(reporte);
        } 

        private static void IndexReportes()
        {
            foreach (var reportes in _repoReporte.GetAllReportes())
            {
                Console.WriteLine(reportes.MarcadorFinal + " " +"Tarjetas amarillas:"+ reportes.TarjetasAmarillas+" "+"Tarejtas Rojas"+reportes.TarjetasRojas );
            }
        }
        private static void DeleteReporte()
        {
            _repoReporte.DeleteReporte(3);
        }


        private static void AddJugadores()
        {
            var jugadores = new Jugadores
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
            var Partido = new Partidos 
            {
                Id = "",
                FechaHora = "",
                EquipoLocal = "",
                MarcadorInicial = "0-0",
                EquipoVisitante = "",
                MarcadorFinal = " - ",
                Colegio = ""
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
            var DesempeñoEquipos = new DesempeñoEquipos 
            {
                Id = "",
                FechaHora = "",
                Cantidad_Partidos_Jugados = "5",
                Cantidad_Partidos_Ganados = "",
                Cantidad_Partidos_Empatados = "",
                GF = "",
                GC = "",
                Puntos = ""
            };
            _repoDesempeñoEquipos.AddDesempeñoEquipos(DesempeñoEquipos);
        }
        private static void IndexDesempeñoEquipos ()
        {
            foreach (var DesempeñoEquipos in _repoDesempeñoEquipos.GetAllDesempeñoEquipos)
            {
                Console.WriteLine(DesempeñoEquipos.Id);
            }
        }
        private static void DeleteDesempeñoEquipos()
        {
            _repoDesempeñoEquipos.DeleteDesempeñoEquipos(2); 
        }
        //Program Goles
        private static void AddGoles()
        {
            var Goles = new Goles
            {
                
            };
            _repoGoles.AddGoles(Goles);
        }
        
        private static void IndexGoles()
        {
            foreach (var goles in _repoGoles.GetAllGoles())
            {
                Console.WriteLine(Goles.Id);
            }
        }
        private static void DeleteGoles()
        {
            _repoGoles.DeleteGoles(2);
        }
        //Program Arbitros
        private static void AddArbitros()
        {
            var Arbitros = new Arbitros
            {
                Nombre = "",
                Documento = "",
                Telefono = "",
                Colegio = ""
            };
            _repoArbitros.AddArbitros(Arbitros);
        }
        
        private static void IndexArbitros()
        {
            foreach (var arbitros in _repoArbitros.GetAllArbitros())
            {
                Console.WriteLine(Arbitros.Id);
            }
        }
        private static void DeleteArbitros()
        {
            _repoArbitros.DeleteArbitros(2);
        }
    }
}
