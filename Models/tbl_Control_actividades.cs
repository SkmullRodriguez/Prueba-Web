using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_Web.Models
{
    public class tbl_Control_actividades
    {
        [Key]
        public int Id_control_actividad { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha_actividad { get; set; }

        public int Actividades { get; set; }

        // llaves fornaeas
        public int Id_usuario { get; set; }

        // relaciones
        [ForeignKey("Id_usuario")]
        public tbl_Usuarios _Usuarios { get; set; }
    }
}
