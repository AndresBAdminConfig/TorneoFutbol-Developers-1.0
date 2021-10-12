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
    public class EditModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public DirectorTecnico director_tecnico {get; set;}
        public EditModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
        }

        public IActionResult OnGet(int id)
        {
            director_tecnico = _repoDirectorTecnico.GetDirectorTecnico(id);
            if (director_tecnico == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(DirectorTecnico director_tecnico)
        {
            _repoDirectorTecnico.UpdateDirectorTecnico(director_tecnico);
            return RedirectToPage("Index");
        } 
    }
}
