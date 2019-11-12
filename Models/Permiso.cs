using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tercer_Parcial.Models;

namespace Segundo_Parcial.Models
{
    public class Permiso
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(200)]
        public string Descripcion { get; set; }
        
        [NotMapped]
        public List<RolesPermisos> RolesPermisos { get; set; }
    }
}