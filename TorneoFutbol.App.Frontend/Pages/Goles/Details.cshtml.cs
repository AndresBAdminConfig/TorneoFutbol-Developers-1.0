using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Goles
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioGol _repoGoles;
        public Gol gol {get; set;}
        public DetailsModel(IRepositorioGol repoGoles)
        {
            _repoGoles = repoGoles;
        }
        public IActionResult OnGet(int Id)
        {
            gol = _repoGoles.GetGoles(Id);
            if (gol == null)
            {
                return NotFound();
            } else {
                return Page();
            }
        }
    }
}
