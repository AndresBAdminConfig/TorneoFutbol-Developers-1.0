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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioGoles _repoGoles;
        public IEnumerable<Gol> goles {get; set;}
        public IndexModel(IRepositorioGoles repoGoles)
        {
            _repoGoles = repoGoles;
        }
        public void OnGet()
        {
            goles = _repoGoles.GetAllGoles();
        }
    }
}
