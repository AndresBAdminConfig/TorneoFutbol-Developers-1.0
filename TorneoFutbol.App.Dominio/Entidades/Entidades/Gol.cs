using System;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbol.App.Dominio
{
    public class Gol
    {
        // Identificador único de cada persona
        public int  Id { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public DateTime MinutoGol { get; set; }
        //Relacion Goles con Jugador
        public Jugador jugador {get; set;}
        

    }
}
