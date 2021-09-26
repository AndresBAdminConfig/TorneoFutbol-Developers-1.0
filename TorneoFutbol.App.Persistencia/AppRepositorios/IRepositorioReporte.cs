using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{

    public interface IRepositorioReporte
    {
        Reporte AddReporte(Reporte reporte);
        IEnumerable<Reporte> GetAllReportes();
        void DeleteReporte(int idReporte);
        Reporte GetReporte(int idReporte);
        Reporte UpdateReporte(Reporte reporte);

    }

}