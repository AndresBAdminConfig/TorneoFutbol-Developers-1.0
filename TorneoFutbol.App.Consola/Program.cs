using System;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;
namespace TorneoFutbol.App.Consola
{
    class Program
    {
        private static IRepositorioEstadios _repoEstadio =  new RepositorioEstadios(new Persistencia.AppContext());                
        private static IRepositorioReporte _repoReporte =  new RepositorioReporte(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddEstadio();
            //DeleteEstadio();
            //IndexEstadios();
            //AddReporte();
            //DeleteReporte();
            //IndexReportes();

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
    }
}
