using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_Web.Models
{
    public class tbl_Marcaciones
    {
        [Key]
        public int Id_marcacion { get; set; }
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Fecha_marcacion { get; set; }
        // Llaves foraneas
        public int Id_usuario { get; set; }

        // relaciones
        [ForeignKey("Id_usuario")]
        public tbl_Usuarios _Usuarios { get; set; }

    }
}
