using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Arbitros
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioArbitros _repoArbitros;
        public Arbitro arbitro {get; set;}
        public DetailsModel(IRepositorioArbitros repoArbitros)
        {
            _repoArbitros = repoArbitros;
        }
        public IActionResult OnGet(int Id)
        {
            arbitro = _repoArbitros.GetArbitros(Id);
            if (arbitro == null)
            {
                return NotFound();
            } else {
                return Page();
            }
        }
    }
}
