using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Prueba_Web.Models
{
    public class tbl_Clientes
    {
        [Key]
        public int Id_cliente { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        public Boolean Estado { get; set; }

    }
}
