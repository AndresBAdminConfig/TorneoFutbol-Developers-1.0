using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;


namespace TorneoFutbol.App.Frontend.Pages.Director_Tecnico
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public IEnumerable<DirectorTecnico> director_tecnico {get; set;}
        public IndexModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public void OnGet()
        {
            director_tecnico = _repoDirectorTecnico.GetAllDirectorTecnico();
        }
    }
}
