using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Segundo_Parcial.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required, MaxLength(16)]
        public string Nombre { get; set; }

        [Required, MaxLength(200)]
        public string Contraseña { get; set; }

        [Required, MaxLength(200)]
        public string CorreoElectronico { get; set; }

        [MaxLength(200)]
        public string Recordatorio { get; set; }

        [Required]
        public Estado Estado { get; set; }

        [NotMapped]
        public Alumno Alumno { get; set; }

        [NotMapped]
        public Tutor Tutor { get; set; }

        [NotMapped]
        public Coordinador Coordinador { get; set; }
    }
    public enum Estado
    {
        Activo = 1,
        Inactivo = 0
    }
}