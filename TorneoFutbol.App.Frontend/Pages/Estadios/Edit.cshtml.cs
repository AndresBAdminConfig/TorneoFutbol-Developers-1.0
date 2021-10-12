using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Page.Estadios
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        public Estadio estadio{get; set;}

        public EditModel(IRepositorioEstadio repoEstadio)
        {
            _repoEstadio = repoEstadio;
        }      
                 
        public IActionResult OnGet(int id)
        {
            estadio = _repoEstadio.GetEstadio(id);
            if(estadio == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Estadio estadio)
        {
            _repoEstadio.UpdateEstadio(estadio);
            return RedirectToPage("Index");
        }
    }
}
