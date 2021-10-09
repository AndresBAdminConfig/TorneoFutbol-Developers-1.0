using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.DesempeñoEquipo
{
    

    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDesempeñoEquipo _repoDesempeño;
        public DesempeñoEquipo Desempeño {get; set;}
        public DetailsModel(IRepositorioDesempeñoEquipo repoDesempeño)
        {
            _repoDesempeño = repoDesempeño;
        }
        public void OnGet(int id)
        {
            DesempeñoEquipo _repoDesempeño.GetDesempeñoEquipo(id);
            if (Desempeño ==null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(DesempeñoEquipo Desempeño)
        {
            _repoDesempeño.AddDesempeñoEquipo(Desempeño);
            return RedirectToPage("Index");
        }
    }
}
