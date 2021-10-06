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
        private readonly IRepositorioArbitros _repoArbitros;
        public IEnumerable<Arbitro> arbitros {get; set;}
        public IndexModel(IRepositorioArbitros repoArbitros)
        {
            _repoArbitros = repoArbitros;
        }
        public void OnGet()
        {
            arbitros = _repoArbitros.GetAllArbitros();
        }
    }
}
