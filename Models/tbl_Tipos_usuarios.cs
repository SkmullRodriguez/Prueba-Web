using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Prueba_Web.Models
{
    public class tbl_Tipos_usuarios
    {
        [Key]
        public int Id_tipo_usuario { get; set; }
        public string Nombre { get; set; }
        
        // relaciones
        public ICollection<tbl_Usuarios> _Tipos_Usuarios { get; set; }

    }
}
