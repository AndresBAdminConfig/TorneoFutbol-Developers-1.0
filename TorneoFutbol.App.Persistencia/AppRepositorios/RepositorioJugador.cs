using System.Collections.Generic;
using TorneoFutbol.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {

        private readonly AppContext _appContext = new AppContext();   
        
        Jugador IRepositorioJugador.AddJugadores(Jugador jugadores)
        {
            var jugadorAdicionado = _appContext.Jugadores.Add(jugadores);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        }
        IEnumerable<Jugador> IRepositorioJugador.GetAllJugador()
        {
            return _appContext.Jugadores;
        }
        public void DeleteJugador(int idJugador)
        {
            var JugadorEncontrado = _appContext.Jugadores.Find(idJugador);
            if (JugadorEncontrado == null)
                return;
            _appContext.Jugadores.Remove(JugadorEncontrado);
            _appContext.SaveChanges();
        }
        Jugador IRepositorioJugador.GetJugador(int idJugador)
        {
            var jugador = _appContext.Jugadores
                        .Where(p => p.Id == idJugador)
                        .Include(p => p.Equipos)
                        .FirstOrDefault();
            return jugador;
           // return _appContext.Jugadores.Find(idJugador);
        }  
        public Jugador UpdateJugador(Jugador jugadores)
        {
            var JugadorEncontrado = _appContext.Jugadores.Find(jugadores.Id);
            if (JugadorEncontrado != null)
            {
                JugadorEncontrado.Nombre = jugadores.Nombre;
                JugadorEncontrado.Numero = jugadores.Numero;
                JugadorEncontrado.Posicion = jugadores.Posicion;
                _appContext.SaveChanges();
            }
            return JugadorEncontrado;
        }
        Equipo IRepositorioJugador.AsignarEquipo(int idJugador, int idEquipo)
        {
            var JugadorEncontrado = _appContext.Jugadores.Find(idJugador);
            if (JugadorEncontrado != null)
            {
                var EquipoEncontrado = _appContext.Equipos.Find(idEquipo);
                if (EquipoEncontrado != null)
                {
                    JugadorEncontrado.Equipos = EquipoEncontrado;
                    _appContext.SaveChanges();
                }  
                return EquipoEncontrado;
            }
            return null;
        }
        IEnumerable<Jugador> IRepositorioJugador.SearchJugador(string nombre)
        {
            return _appContext.Jugadores
                        .Where(p => p.Nombre.Contains(nombre));
        }
    }
}