using System;
namespace TorneoFutbol.App.Dominio
{
    public class Partido
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        public String FechaHora { get; set; }
        public string EquipoLocal { get; set; }
        public String MarcadorInicial { get; set; }
        public String EquipoVisitante { get; set; }
        public string MarcadorFinal { get; set; }
        public string Colegio { get; set; }
        //Relacion Partido y Equipos
        public System.Collections.Generic.List<Equipo> Equipos { get; set; }
        //Relacion partido y arbitro
        public Arbitro Arbitros {get; set;}
        


    }
}