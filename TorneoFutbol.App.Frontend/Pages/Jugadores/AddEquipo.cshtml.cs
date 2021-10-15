using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbol.App.Persistencia;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Frontend.Jugadores
{
    public class AddEquipoModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        private readonly IRepositorioEquipo _repoEquipo;
        public Jugador jugador{get; set;}
        public IEnumerable<Equipo> equipos {get; set;}
        public AddEquipoModel(IRepositorioJugador repoJugador, IRepositorioEquipo repoEquipo)
        {
            _repoJugador = repoJugador;
            _repoEquipo = repoEquipo;
        }
        public void OnGet(int id)
        {
            jugador = _repoJugador.GetJugador(id);
            equipos = _repoEquipo.GetAllEquipo();
        }
        public IActionResult OnPost(int idJugador, int idEquipo)
        {
            _repoJugador.AsignarEquipo(idJugador,idEquipo);
            return RedirectToPage("Details", new {id =idJugador});
        }
    }
}
