using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{

    public interface IRepositorioReporte
    {
        Reporte AddReporte(Reporte reporte);
        IEnumerable<Reporte> GetAllReportes();
        void DeleteReporte(int idReporte);
        public Reporte GetReporte(int idReporte);
        public Reporte UpdateReporte(Reporte reporte);

    }

}