using System;
namespace TorneoFutbol.App.Dominio
{
    public class Gol
    {
        // Identificador único de cada persona
        public int  Id { get; set; }
        public DateTime MinutoGol { get; set; }
        //Relacion Goles con Jugador
        public Jugador Jugadores{get; set;}
        

    }
}
