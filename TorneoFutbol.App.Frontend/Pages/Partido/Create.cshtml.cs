using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TorneoFutbol.App.Frontend.Pages.Partido
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPartido CreateModel._repoPartido();
        public Partido partido { get; set;}
        public CreateModel(IRepositorioPartido repoPartido)
        {
            _repoPartido = repoPartido;
        }
        public void OnGet()
        {
            partido = New Partido();
        }
        
    }
}
