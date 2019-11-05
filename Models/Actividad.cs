using System;
using System.ComponentModel.DataAnnotations;

namespace Segundo_Parcial.Models
{
    public class Actividad
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Tipo { get; set; }

        [Required, MaxLength(50)]
        public string Denominacion { get; set; }

        [Required]
        public int Horas { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required, MaxLength(200)]
        public string Descripcion { get; set; }

        [Required, MaxLength(100)]
        public string Institucion { get; set; }
    }
}