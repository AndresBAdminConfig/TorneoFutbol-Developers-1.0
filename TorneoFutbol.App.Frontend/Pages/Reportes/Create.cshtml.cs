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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioReporte _repoReporte;
        public Reporte reporte{get; set;}
        public CreateModel(IRepositorioReporte repoReporte)
         {
            _repoReporte = repoReporte;
        }       
        public void OnGet()
        {
            reporte = new Reporte();
        }
         public IActionResult OnPost(Reporte reporte)
        {
            _repoReporte.AddReporte(reporte);
            return RedirectToPage("Index");
        }
    }
}
