using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Partido
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPartido _RepoPartido;
        public IEnumerable<Partido> partido {get; set;}
        public IndexModel(IRepositorioPartido RepoPartido)
        {
            _RepoPartido = RepoPartido;
        }
        public string bActual{get; set;}
        public void OnGet(string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                partido = _RepoPartido.GetAllPartidos();
            }
            else
            {
                bActual = b;
                partido = _RepoPartido.SearchPartidos();
            }
        }
    }
}