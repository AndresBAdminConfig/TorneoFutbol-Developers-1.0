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
        
    }
}
