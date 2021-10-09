using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TorneoFutbol.App.Frontend.Pages.DesempeñoEquipo
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDesempeñoEquipo _repoDesempeño;
        public DesempeñoEquipo Desempeño {get; set;}
        public CreateModel(IRepositorioDesempeñoEquipo repoDesempeño)
        {
            _repoDesempeño = repoDesempeño;
        }
        public void OnGet()
        {
            Desempeño = New DesempeñoEquipo();
        }
    }
}
