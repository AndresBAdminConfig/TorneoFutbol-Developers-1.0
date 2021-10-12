using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Persistencia;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Frontend.Director_Tecnico
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public DirectorTecnico director_tecnico {get; set;}
        public CreateModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public void OnGet()
        {
            director_tecnico = new DirectorTecnico();
        }

        public IActionResult OnPost(DirectorTecnico director_tecnico)
        {
            if (ModelState.IsValid)
            {
                _repoDirectorTecnico.AddDirectorTecnico(director_tecnico);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
            
        }
    }
}
