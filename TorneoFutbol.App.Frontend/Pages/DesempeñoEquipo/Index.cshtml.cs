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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDesempeñoEquipo _RepoDesempeño;
        public IEnumerable<DesempeñoEquipo> Desempeño {get; set;}
        public IndexModel (IRepositorioDesempeñoEquipo RepoDesempeño)
        {
            _RepoDesempeño = RepoDesempeño;
        }
        public void OnGet()
        {
            desempeño = _RepoDesempeño.GetAllDesempeñoEquipo();
        }
    }
}
