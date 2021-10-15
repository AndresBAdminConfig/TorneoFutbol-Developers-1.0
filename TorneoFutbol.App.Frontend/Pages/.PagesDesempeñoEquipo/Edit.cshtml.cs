using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.pages.DesempeñoEquipo
{
    public class EditModel : PageModel
    {
        private readonly IrepositorioDesempeñoEquipo _repoDesempeño;
        public DesempeñoEquipo Desempeño {get; set;}
        public EditModel(IrepositorioDesempeñoEquipo repoDesempeño)
        {
            _repoDesempeño = repoDesempeño;
        }
        public IActionResult OnGet(int id)
        {
            Desempeño = _repoDesempeño.getDesempeño(id);
            if (Desempeño == null)
            {
                return = NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(DesempeñoEquipo Desempeño)
        {
            _repoDesempeño.UpdateDesempeñoEquipo(Desempeño);
            return RedirectToPage("Index");
        }
    }
}