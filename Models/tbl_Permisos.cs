using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_Web.Models
{
    public class tbl_Permisos
    {
        [Key]
        public int Id_permiso { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.Date)]
        public DateTime Fecha_permiso { get; set; }
        public Boolean Estado { get; set; }
        // llaves foraneas
        public int Id_usuario { get; set; }

        // relaciones
        [ForeignKey("Id_usuario")]
        public tbl_Usuarios _Usuarios { get; set; }
    }
}
