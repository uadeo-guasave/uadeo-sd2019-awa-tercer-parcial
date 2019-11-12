using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Segundo_Parcial.Models;

namespace Tercer_Parcial.Models
{
    public class RolesPermisos
    {
        [Required]
        public int RolId { get; set; }

        [Required]
        public int PermisoId { get; set; }

        [NotMapped]
        public Rol Rol { get; set; }

        [NotMapped]
        public Permiso Permiso { get; set; }
    }
}