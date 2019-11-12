using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tercer_Parcial.Models;

namespace Segundo_Parcial.Models
{
    public class Rol
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public NombreDeRol Nombre { get; set; }

        [NotMapped]
        public List<RolesPermisos> RolesPermisos { get; set; }
    }

    public enum NombreDeRol
    {
        Coordinador,
        Tutor,
        Alumno
    }
}