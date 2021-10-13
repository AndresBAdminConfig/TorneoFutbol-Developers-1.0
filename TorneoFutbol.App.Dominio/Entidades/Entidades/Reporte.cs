using System.ComponentModel.DataAnnotations;
namespace TorneoFutbol.App.Dominio
{
    public class Reporte
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        [Display(Name = "Macador Final")]
        [Required(ErrorMessage = "El Marcador Final es obligatorio")]
        [StringLength(3,ErrorMessage = "Maximo 3 caracteres")]
        public string MarcadorFinal { get; set; }
        [Display(Name = "Tarjetas Amarillas")]
        [Required(ErrorMessage = "Las Taregetas Amarillas es obligatorio")]
        [StringLength(2,ErrorMessage = "Maximo 2 caracteres")]
        public string TarjetasAmarillas { get; set; }
        [Display(Name = "Tarejetas Rojas ")]
        [Required(ErrorMessage = "Las Taregetas Rojas es obligatorio")]
        [StringLength(1,ErrorMessage = "Maximo 1 caracteres")]
        public string TarjetasRojas { get; set; }
        //Relacion Reporte y Goles
        public System.Collections.Generic.List<Gol> Goles { get; set; }
        //Relacion Reporte y Partido
        public Partido  Partidos { get; set; }
        

    }
}