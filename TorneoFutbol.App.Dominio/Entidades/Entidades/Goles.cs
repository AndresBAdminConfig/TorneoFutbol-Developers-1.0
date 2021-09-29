using System;
namespace TorneoFutbol.App.Dominio
{
    public class Goles
    {
        // Identificador único de cada persona
        public int  Id { get; set; }
        public String MinutoGol { get; set; }
        //Relacion Goles con Jugador
        public Jugadores Jugadores{get; set;}
        

    }
}