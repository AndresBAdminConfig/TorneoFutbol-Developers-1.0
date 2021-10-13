using System.ComponentModel.DataAnnotations;
namespace TorneoFutbol.App.Dominio
{
    public class Jugador
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        [Display(Name = "Nombre Completo")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(30,ErrorMessage = "Maximo 30 caracteres")] 
        public string Nombre { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "El número es obligatorio")]
        [StringLength(02,ErrorMessage = "Maximo 02 caracteres")] 
        public string Numero { get; set; }

        [Display(Name = "Posición")]
        [Required(ErrorMessage = "La posición es obligatoria")]
        [StringLength(30,ErrorMessage = "Maximo 30 caracteres")] 
        public string Posicion { get; set; }
        //Relación entre Jugadores y equipos
        public Equipo Equipos{get; set;}

    }
}