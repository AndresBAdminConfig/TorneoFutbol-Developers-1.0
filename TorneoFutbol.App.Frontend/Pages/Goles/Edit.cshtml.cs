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
    public class EditModel : PageModel
    {
        private readonly IRepositorioGol _repoGoles;
        public Gol gol {get; set;}
        public EditModel(IRepositorioGol repoGoles)
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

        public IActionResult OnPost (Gol gol)
        {
            _repoGoles.AddGoles(gol);
            return RedirectToPage("Index");
        }
    }
}
