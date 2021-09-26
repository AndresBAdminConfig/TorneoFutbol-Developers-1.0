using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioJugador
    {
        Jugadores AddJugadores(Jugadores jugadores);
        IEnumerable<Jugadores> GetAllJugador();
        void DeleteJugador(int idJugador);
        public Jugadores GetJugador(int idJugador);
        public Jugadores UpdateJugador(Jugadores jugadores);
    }
}