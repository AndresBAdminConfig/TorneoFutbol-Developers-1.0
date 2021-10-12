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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitros;
        public Arbitro arbitro {get; set;}
        public CreateModel(IRepositorioArbitro repoArbitros)
        {
            _repoArbitros = repoArbitros;
        }
        public void OnGet()
        {
            arbitro = new  Arbitro();
        }
        public IActionResult OnPost (Arbitro arbitro)
        {
            if (ModelState.IsValid)
            {
                _repoArbitros.AddArbitros(arbitro);
                return RedirectToPage("Index"); 
            } else {
                return Page();
            }
            
        }
    }
}