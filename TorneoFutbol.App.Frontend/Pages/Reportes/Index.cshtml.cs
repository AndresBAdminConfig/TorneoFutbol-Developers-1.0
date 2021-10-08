using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Reportes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioReporte _repoReporte;
        public IEnumerable<Reporte> reportes {get; set;}
        public IndexModel(IRepositorioReporte repoReporte)
        {
            _repoReporte = repoReporte;
        }
        public void OnGet()
        {
            reportes = _repoReporte.GetAllReportes();
        }
    }
}
