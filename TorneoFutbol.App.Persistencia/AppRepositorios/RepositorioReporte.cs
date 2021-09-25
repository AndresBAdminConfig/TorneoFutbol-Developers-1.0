using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioReporte : IRepositorioReporte
    {
        private readonly AppContext _appContext;   
        public RepositorioReporte(AppContext appContext)
        {
            _appContext = appContext;
        }

        Reporte IRepositorioReporte.AddReporte(Reporte reporte)
        {
            var reporteAdicionado = _appContext.Reportes.Add(reporte);
            _appContext.SaveChanges();
            return reporteAdicionado.Entity;
        }
        IEnumerable<Reporte> IRepositorioReporte.GetAllReportes()
        {
            return _appContext.Reportes;
        }
        public void DeleteReporte(int idReporte)
        {
            var reporteEncontrado = _appContext.Reportes.Find(idReporte);
            if (reporteEncontrado == null)
                return;
            _appContext.Reportes.Remove(reporteEncontrado);
            _appContext.SaveChanges();
        }
        public Reporte GetReporte(int idReporte)
        {
            return _appContext.Reportes.Find(idReporte);
        } 
        public Reporte UpdateReporte(Reporte reporte)
        {
            var reporteEncontrado = _appContext.Reportes.Find(reporte.Id);
            if (reporteEncontrado != null)
            {
                reporteEncontrado.MarcadorFinal = reporte.MarcadorFinal;
                reporteEncontrado.TarjetasAmarillas = reporte.TarjetasAmarillas;
                reporteEncontrado.TarjetasRojas = reporte.TarjetasRojas;
                reporteEncontrado.IdPartido = reporte.IdPartido; 
                _appContext.SaveChanges();
            }
            return reporteEncontrado;
        } 
    }
}
    
