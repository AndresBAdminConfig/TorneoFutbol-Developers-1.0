using System;
namespace TorneoFutbol.App.Dominio
{
    public class Goles
    {
        // Identificador único de cada persona
        public int  Id { get; set; }
        public DateTime MinutoGol { get; set; }
        public Jugadores Jugadores{get; set;}
        

    }
}