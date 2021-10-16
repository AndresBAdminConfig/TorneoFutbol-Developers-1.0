using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Dominio;
using TorneoFutbol.App.Persistencia;

namespace TorneoFutbol.App.Frontend.Pages.Partidos
{
    public class AddArbitrosModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        private readonly IrepositorioArbitro _repoArbitro;
        public Partido partido {get; set;}
        public AddArbitrosModel(IRepositorioPartido repoPartido, IRepositorioArbitro repoArbitro)
        {
            _repoPartido = repoPartido;
            _repoArbitro = repoArbitro;
        }
        public void OnGet(int id)
        {
            partido = _repoPartido.GetPartido(id);
            arbitro = _repoArbitro.GetAllArbitros();
        }
        public IActionResult OnPost(int idPartido, int idArbitro)
        {
            _repoPartido.AsignarArbitro(idPartido, idArbitro);
            return RedirectToPage("Details", new {id = idPartido});
        }
    }
}
