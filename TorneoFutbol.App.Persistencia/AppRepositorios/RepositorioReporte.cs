using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioReporte : IRepositorioReporte
    {
        private readonly AppContext _appContext = new AppContext();   
        
        Reporte IRepositorioReporte.AddReporte(Reporte reportes)
        {
            var reporteAdicionado = _appContext.Reportes.Add(reportes);
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
        public Reporte UpdateReporte(Reporte reportes)
        {
            var reporteEncontrado = _appContext.Reportes.Find(reportes.Id);
            if (reporteEncontrado != null)
            {
                reporteEncontrado.MarcadorFinal = reportes.MarcadorFinal;
                reporteEncontrado.TarjetasAmarillas = reportes.TarjetasAmarillas;
                reporteEncontrado.TarjetasRojas = reportes.TarjetasRojas;
                _appContext.SaveChanges();
            }
            return reporteEncontrado;
        } 
    }
}
    
