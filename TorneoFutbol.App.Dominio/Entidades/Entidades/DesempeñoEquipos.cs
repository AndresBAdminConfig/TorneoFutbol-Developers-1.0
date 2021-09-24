using System;
namespace TorneoFutbol.App.Dominio
{
    public class DesempeñoEquipos
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        public int Cantidad_Partidos_Jugados { get; set; }
        public int Cantidad_Partidos_Ganados { get; set; }
        public int Cantidad_Partidos_Empatados { get; set; }
        public int GF { get; set; }
        public int GC { get; set; }
        public int Puntos { get; set; }
                
    }
}