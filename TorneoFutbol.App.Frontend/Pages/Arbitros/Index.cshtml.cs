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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitros;
        public IEnumerable<Arbitro> arbitros {get; set;}
        public IndexModel(IRepositorioArbitro repoArbitros)
        {
            _repoArbitros = repoArbitros;
        }
        public void OnGet()
        {
            arbitros = _repoArbitros.GetAllArbitros();
        }
    }
}
