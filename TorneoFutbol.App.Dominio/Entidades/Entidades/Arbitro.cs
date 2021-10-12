using System.ComponentModel.DataAnnotations;

namespace TorneoFutbol.App.Dominio
{
    public class Arbitro
    {
        // Identificador único de cada persona
        public int  Id  { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres")]
        public string Documento { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(80, ErrorMessage = "Máximo 80 caracteres")]
        public string Colegio { get; set; }

    }
}