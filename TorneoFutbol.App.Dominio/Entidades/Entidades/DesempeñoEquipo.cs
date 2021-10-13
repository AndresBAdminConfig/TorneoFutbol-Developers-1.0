using System;
//using System.ComponentModel.DataAnnotations;

namespace TorneoFutbol.App.Dominio
{
    public class DesempeñoEquipo
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        [Requiered(ErrorMessage = "Los Datos Son Obligatorios")]
        [StringLength(5, ErrorMessage "Maximo 5 Caracteres")]
        public int Cantidad_Partidos_Jugados { get; set; }
        [Requiered(ErrorMessage = "Los Datos Son Obligatorios")]
        [StringLength(5, ErrorMessage "Maximo 5 Caracteres")]
        public int Cantidad_Partidos_Ganados { get; set; }
        [Requiered(ErrorMessage = "Los Datos Son Obligatorios")]
        [StringLength(5, ErrorMessage "Maximo 5 Caracteres")]
        public int Cantidad_Partidos_Empatados { get; set; }
        [Requiered(ErrorMessage = "Los Datos Son Obligatorios")]
        [StringLength(5, ErrorMessage "Maximo 10 Caracteres")]
        public int GF { get; set; }
        [Requiered(ErrorMessage = "Los Datos Son Obligatorios")]
        [StringLength(5, ErrorMessage "Maximo 10 Caracteres")]
        public int GC { get; set; }
        [Requiered(ErrorMessage = "Los Datos Son Obligatorios")]
        [StringLength(5, ErrorMessage "Maximo 10 Caracteres")]
        public int Puntos { get; set; }
                
    }
}