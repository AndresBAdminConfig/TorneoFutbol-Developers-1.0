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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioGol _repoGoles;
        public Gol gol {get; set;}
        //public IEnumerable<Gol> goles {get; set;}
        public CreateModel(IRepositorioGol repoGoles)
        {
            _repoGoles = repoGoles;
        }
        public void OnGet()
        {
            gol = new  Gol();
        }
    }
}
