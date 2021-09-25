using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {

        private readonly AppContext _appContext = new AppContext();   
        
        Jugadores IRepositorioJugador.AddJugadores(Jugadores jugadores)
        {
            var jugadorAdicionado = _appContext.Jugador.Add(jugadores);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        }
        IEnumerable<Jugadores> IRepositorioJugador.GetAllJugador()
        {
            return _appContext.Jugador;
        }
        public void DeleteJugador(int idJugador)
        {
            var JugadorEncontrado = _appContext.Jugador.Find(idJugador);
            if (JugadorEncontrado == null)
                return;
            _appContext.Jugador.Remove(JugadorEncontrado);
            _appContext.SaveChanges();
        }
        public Jugadores GetJugador(int idJugador)
        {
            return _appContext.Jugador.Find(idJugador);
        }  
        public Jugadores UpdateJugador(Jugadores jugadores)
        {
            var JugadorEncontrado = _appContext.Jugador.Find(jugadores.Id);
            if (JugadorEncontrado != null)
            {
                JugadorEncontrado.Nombre = jugadores.Nombre;
                JugadorEncontrado.Numero = jugadores.Numero;
                JugadorEncontrado.Posicion = jugadores.Posicion;
                _appContext.SaveChanges();
            }
            return JugadorEncontrado;
        } 
    }
}