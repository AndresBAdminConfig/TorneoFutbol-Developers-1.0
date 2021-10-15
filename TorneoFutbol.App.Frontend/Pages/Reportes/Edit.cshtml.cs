using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Page.Reportes
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioReporte _repoReporte;
        public Reporte reporte{get; set;}

        public EditModel(IRepositorioReporte repoReporte)
        {
            _repoReporte = repoReporte;
        }        
        public IActionResult OnGet(int id)
        {
            reporte = _repoReporte.GetReporte(id);
            if(reporte == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Reporte reporte)
        {
            _repoReporte.UpdateReporte(reporte);
            return RedirectToPage("Index");
        }
    }
}