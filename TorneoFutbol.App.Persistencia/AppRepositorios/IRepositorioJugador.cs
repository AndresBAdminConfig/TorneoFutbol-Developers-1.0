using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioJugador
    {
        Jugador AddJugadores(Jugador jugadores);
        IEnumerable<Jugador> GetAllJugador();
        void DeleteJugador(int idJugador);
        Jugador GetJugador(int idJugador);
        Jugador UpdateJugador(Jugador jugador);
        Equipo AsignarEquipo(int idJugador, int idEquipo);
    }
}